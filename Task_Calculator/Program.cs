namespace Task_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Calculadora";

            while (true)
            {
                Console.Clear();
                MostrarEncabezado();

                double num1 = PedirNumero("Ingrese el primer número: ");
                double num2 = PedirNumero("Ingrese el segundo número: ");
                char operacion = PedirOperacion();

                double resultado = Calcular(num1, num2, operacion);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"\nEl resultado de {num1} {operacion} {num2} es: {resultado}");
                Console.ResetColor();

                Console.WriteLine("\nPresiona Enter para otra operación o ESC para salir...");
                if (Console.ReadKey().Key == ConsoleKey.Escape) break;
            }
        }

        static void MostrarEncabezado()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("╔══════════════════════╗");
            Console.WriteLine("║      CALCULADORA     ║");
            Console.WriteLine("╚══════════════════════╝");
            Console.ResetColor();
        }

        static double PedirNumero(string mensaje)
        {
            double numero;
            while (true)
            {
                Console.Write(mensaje);
                if (double.TryParse(Console.ReadLine(), out numero))
                    return numero;

                MostrarError("⚠ Error: Ingresa un número válido.");
            }
        }

        static char PedirOperacion()
        {
            while (true)
            {
                Console.Write("Ingrese la operación (+, -, *, /): ");
                string input = Console.ReadLine();
                if (!string.IsNullOrEmpty(input) && "+-*/".Contains(input))
                    return input[0];

                MostrarError("⚠ Error: Ingresa una operación válida.");
            }
        }

        static double Calcular(double num1, double num2, char operacion)
        {
            switch (operacion)
            {
                case '+': return num1 + num2;
                case '-': return num1 - num2;
                case '*': return num1 * num2;
                case '/': return num2 != 0 ? num1 / num2 : MostrarError("⚠ Error: No se puede dividir entre cero.", true);
                default: return 0;
            }
        }

        static double MostrarError(string mensaje, bool esRetorno = false)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(mensaje);
            Console.ResetColor();
            return esRetorno ? 0 : double.NaN;
        }
    }
}
