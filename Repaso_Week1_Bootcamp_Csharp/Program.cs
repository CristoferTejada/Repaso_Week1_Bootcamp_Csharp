namespace Repaso_Week1_Bootcamp_Csharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //
            Console.WriteLine("=============================");
            int dni = 2233333;
            int edad = 8;
            double numeroDecimal = 10.00;
            char caracter = '1';
            bool esMayordeEdad = true;
            string nombre = "Andre"; // referencia

            if (dni != 2233333 || !esMayordeEdad)
            {
                Console.WriteLine("No es mi numero de dni");
                if (esMayordeEdad)
                {
                    Console.WriteLine("");
                }
            }
            else
            {
                Console.WriteLine("Si es mi numero de dni");
            }

            // Dias de la semana
            Console.WriteLine("=============================");
            Console.WriteLine("Dias de la semana");
            Console.WriteLine("=============================");
            String diaSemana = "Lunes";

            switch (diaSemana)
            {
                case "Lunes":
                    Console.WriteLine("El dia es lunes");
                    break;
                case "Martes":
                    Console.WriteLine("El dia es martes");
                    break;
                default:
                    Console.WriteLine("No es un dia de la semana");
                    break;
            }

            Console.WriteLine("Saliendo de la aplicacion");

            // Comprobar si un numero es impar o par
            Console.WriteLine("=============================");
            Console.Write("Ingrese un número: ");
            Console.WriteLine("=============================");
            int num = int.Parse(Console.ReadLine());

            if (num % 2 == 0)
                Console.WriteLine($"{num} es un número par.");
            else
                Console.WriteLine($"{num} es un número impar.");

            //

            Console.Write("Ingrese el primer número: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el segundo número: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el tercer número: ");
            int num3 = int.Parse(Console.ReadLine());

            int mayor;
            if (num1 >= num2 && num1 >= num3)
                mayor = num1;
            else if (num2 >= num1 && num2 >= num3)
                mayor = num2;
            else
                mayor = num3;

            Console.WriteLine($"El número más grande es: {mayor}");

            // Obtener el area del circulo o del cuadrado
            Console.WriteLine("===============================================");
            Console.WriteLine("Seleccione la figura para calcular el área:");
            Console.WriteLine("===============================================");
            Console.WriteLine("1. Círculo");
            Console.WriteLine("2. Rectángulo");
            Console.Write("Ingrese su elección: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:

                    Console.Write("Ingrese el radio del círculo: ");
                    double radio = double.Parse(Console.ReadLine());
                    double areaCirculo = Math.PI * radio * radio;
                    Console.WriteLine($"El área del círculo es: {areaCirculo:F6}");
                    break;

                case 2:

                    Console.Write("Ingrese el largo del rectángulo: ");
                    double largo = double.Parse(Console.ReadLine());
                    Console.Write("Ingrese el ancho del rectángulo: ");
                    double ancho = double.Parse(Console.ReadLine());
                    double areaRectangulo = largo * ancho;
                    Console.WriteLine($"El área del rectángulo es: {areaRectangulo}");
                    break;

                default:
                   
                    Console.WriteLine("Error: opción no válida. Por favor seleccione 1 para círculo o 2 para rectángulo.");
                    break;
            }


        }
    }
}
