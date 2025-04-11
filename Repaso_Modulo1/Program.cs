namespace Repaso_Modulo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==================");
            Console.WriteLine("Repaso bucles");
            /*
             * *
             * * *
             * * * *
             * * * * *
             */

            // For loop:
            int i, j, filas;
            Console.WriteLine("Ingresa el numero de filas");
            filas = Convert.ToInt32(Console.ReadLine());

            for (i = 1; i <= filas; i++)
            {
                for (j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.Write("\n");
            }
            Console.WriteLine("Se acabo el bucle");

            /*
             * 1
             * 1 2
             * 1 2 3
             * 1 2 3 4
             */

            // Contar los duplpicados dentro de un arreglo 
            // int[] arreglo = new int[] {44, 44, 32, 35}
            // Resultado: hay dos valores duplicados en el arreglo

            int[] arreglo = new int[] { 44, 44, 32, 35, 44, 32, 10 };
            ContarDuplicadosEnArreglo(arreglo);
        }
        public static void ContarDuplicadosEnArreglo(int[] arr)
        {
            if (arr == null || arr.Length == 0)
            {
                Console.WriteLine("El arreglo está vacío o es nulo.");
                return;
            }

            
            Dictionary<int, int> frecuencia = new Dictionary<int, int>();

            
            foreach (int numero in arr)
            {
                if (frecuencia.ContainsKey(numero))
                {
                    frecuencia[numero]++;
                }
                else
                {
                    frecuencia[numero] = 1;
                }
            }

            int cantidadDuplicados = 0;
            List<int> valoresDuplicados = new List<int>();

            
            foreach (KeyValuePair<int, int> par in frecuencia)
            {
                if (par.Value > 1)
                {
                    cantidadDuplicados += par.Value - 1; 
                    valoresDuplicados.Add(par.Key);
                }
            }

            if (cantidadDuplicados > 0)
            {
                Console.WriteLine($"Hay {cantidadDuplicados} valores duplicados en el arreglo.");
                Console.Write("Los valores duplicados son: ");
                Console.WriteLine(string.Join(", ", valoresDuplicados));
            }
            else
            {
                Console.WriteLine("No hay valores duplicados en el arreglo.");
            }
        }
    }
}
