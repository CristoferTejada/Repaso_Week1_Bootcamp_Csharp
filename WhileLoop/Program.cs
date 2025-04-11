namespace WhileLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido a los while loops");

            // Escribir un bucle infinito
             int contador = 0;
             while (contador <= 10)
             {
                 Console.WriteLine("El valor es: " + contador);
                 contador++;
             }
             Console.WriteLine("Se acabo el bucle");

            // Tabla de multiplicar
            // 10 = 10x1, 10x2, 10x3.... 10x12

            int contadorTabla = 1;
            Console.WriteLine("Ingrese el valor de la tabla de multiplicar");
            int valorTabla;
            int resultado;
            valorTabla = Convert.ToInt32(Console.ReadLine());
            while (contadorTabla <= 12)
            {

                resultado = valorTabla * contadorTabla;
                Console.WriteLine("La tabla del numero: " + valorTabla + " es igual a " + valorTabla + "x" + contadorTabla + " = " + resultado);
                contadorTabla++;
            }

            // Imprimir cuadrado con patrones de 1 al 5

            int i = 1;

            while (i <= 5) 
            {
                int j = 1;

                while (j <= 5) 
                {
                    Console.Write(j + " ");
                    j++;
               }

                Console.WriteLine(); 
                i++;
            }

            //Ejercicio de while loop

            int i = 1;

            while (i <= 5)
            {
                int j = 1;

               
                while (j <= i)
                {
                    Console.Write(j + " ");
                    j++;
                }

                
                int k = 1;
                while (k <= 5 - i)
                {
                    Console.Write("* ");
                    k++;
                }

                Console.WriteLine(); 
                i++;
            }

            // Crear un bucle tipo for
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Número: " + i);
            }

            // 1 Challenge
            // Write a program in C# Sharp to display the multiplication table of a given integer.

            Console.Write("Ingrese el número (Tabla a calcular): ");
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{num} X {i} = {num * i}");
            }

            // 2 Challenge
            // El mismo patrón que hicimos con while pero con for
            

            for (int i = 1; i <= 5; i++)
            {
                
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");
                }

                
                for (int k = 1; k <= 5 - i; k++)
                {
                    Console.Write("* ");
                }

                Console.WriteLine(); 
            }
            
            // Patron Inverso
            int fila = 1;
            while (fila <= 5)
            {
                int espacios = 5 - fila;
                while (espacios > 0)
                {
                    Console.Write("* ");
                    espacios--;
                }

                int num = 1;
                while (num <= fila)
                {
                    Console.Write(num + " ");
                    num++;
                }

                Console.WriteLine();
                fila++;
            }

        }
    }
}
