namespace Week2_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {

        // Console.WriteLine("ARRAYS UNIDIMENSIONALES EN C#");
        // Console.WriteLine("============================\n");
        //
        // // 1. Declaración e inicialización de un array
        // Console.WriteLine("1. Declaración e inicialización:");
        //
        // // Forma 1: Declarar y luego inicializar
        // int[] numeros = new int[5]; // Array de 5 enteros
        // numeros[0] = 10;
        // numeros[1] = 20;
        // numeros[2] = 30;
        // numeros[3] = 40;
        // numeros[4] = 50;
        //
        // // Forma 2: Declarar e inicializar en una línea
        // int[] otrosNumeros = new int[] { 10, 20, 30, 40, 50 };
        //
        // // Forma 3: Inicialización implícita
        // string[] nombres = { "Ana", "Juan", "Pedro", "María", "Luis" };
        //
        // // 2. Acceso a los elementos
        // Console.WriteLine("\n2. Acceso a los elementos:");
        // Console.WriteLine($"El primer número es: {numeros[0]}"); // 10
        // Console.WriteLine($"El tercer nombre es: {nombres[2]}"); // Pedro
        // Console.WriteLine($"El ultimo nombre es: {nombres[4]}"); // Luis
        //
        // // 3. Obtener la longitud del array
        // Console.WriteLine("\n3. Longitud del array:");
        // Console.WriteLine($"El array de números tiene {numeros.Length} elementos");
        //
        // // 4. Recorrer un array con un bucle for
        // Console.WriteLine("\n4. Recorrer array con for:");
        // for (int i = 0; i < nombres.Length; i++)
        // {
        //     Console.WriteLine($"Índice {i}: {nombres[i]}");
        // }
        //
        // // 5. Recorrer un array con foreach
        // Console.WriteLine("\n5. Recorrer array con foreach:");
        // foreach (string nombre in nombres)
        // {
        //     Console.WriteLine(nombre);
        // }
        //
        // // 6. Operaciones comunes
        // Console.WriteLine("\n6. Operaciones comunes:");
        //
        // // Sumar todos los elementos
        // int suma = 0;
        // foreach (int numero in numeros)
        // {
        //     suma += numero;
        // }
        // Console.WriteLine($"La suma de todos los números es: {suma}");
        //
        // // Encontrar el valor máximo
        // int maximo = numeros[0];
        // for (int i = 1; i < numeros.Length; i++)
        // {
        //     if (numeros[i] > maximo)
        //         maximo = numeros[i];
        // }
        // Console.WriteLine($"El valor máximo es: {maximo}");
        //
        // // 7. Métodos de Array
        // Console.WriteLine("\n7. Métodos del Array:");
        //
        // // Ordenar un array
        // int[] desordenados = { 5, 2, 8, 1, 9 };
        // Console.Write("Array desordenado: ");
        // foreach (int num in desordenados)
        //     Console.Write($"{num} ");
        //
        // Array.Sort(desordenados);
        // Console.Write("\nArray ordenado: ");
        // foreach (int num in desordenados)
        //     Console.Write($"{num} ");
        //
        // // Invertir un array
        // Array.Reverse(desordenados);
        // Console.Write("\nArray invertido: ");
        // foreach (int num in desordenados)
        //     Console.Write($"{num} ");
        //
        // // Buscar en un array
        // string[] frutas = { "manzana", "pera", "naranja", "plátano", "uva" };
        // int indice = Array.IndexOf(frutas, "naranja");
        // Console.WriteLine($"\nLa naranja está en el índice: {indice}");
        //
        // // Copiar un array
        // int[] copiaNumeros = new int[numeros.Length];
        // Array.Copy(numeros, copiaNumeros, numeros.Length);
        // Console.Write("\nArray copiado: ");
        // foreach (int num in copiaNumeros)
        //     Console.Write($"{num} ");
        //
        // Console.WriteLine("\n");

        /*
            RETO: SISTEMA DE CALIFICACIONES
            Objetivo: Desarrollar un programa que gestione las calificaciones de estudiantes y realice
            diferentes operaciones estadísticas.
            Requisitos:
            1.Crear un array para almacenar las calificaciones de 10 estudiantes(valores entre 0 y 100)
            2.Implementar las siguientes funcionalidades:
               -Calcular el promedio de calificaciones
               -Encontrar la calificación más alta y la más baja
               -Calcular cuántos estudiantes aprobaron(calificación >= 60)
               - Mostrar las calificaciones en orden ascendente
               - Mostrar cuántos estudiantes obtuvieron calificaciones en los siguientes rangos:
                     *0 - 59(Reprobado)
                     * 60 - 69(Suficiente)
                     * 70 - 79(Bien)
                     * 80 - 89(Notable)
                     * 90 - 100(Excelente)

                Extra(opcional):
                -Permitir que el usuario ingrese las calificaciones
                -Implementar un menú para que el usuario elija la operación a realizar
        */

            Console.WriteLine("SISTEMA DE CALIFICACIONES");
            Console.WriteLine("=========================\n");


            double[] calificaciones = new double[10];


            IngresarCalificaciones(calificaciones);

            int opcion;
            do
            {

                Console.WriteLine("\nMENÚ DE OPCIONES");
                Console.WriteLine("1. Mostrar calificaciones");
                Console.WriteLine("2. Calcular estadísticas");
                Console.WriteLine("3. Ordenar calificaciones");
                Console.WriteLine("4. Mostrar distribución por rangos");
                Console.WriteLine("0. Salir");
                Console.Write("Seleccione una opción: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        MostrarCalificaciones(calificaciones);
                        break;
                    case 2:
                        CalcularEstadisticas(calificaciones);
                        break;
                    case 3:
                        OrdenarCalificaciones(calificaciones);
                        break;
                    case 4:
                        MostrarDistribucionRangos(calificaciones);
                        break;
                    case 0:
                        Console.WriteLine("Saliendo del sistema...");
                        break;
                    default:
                        Console.WriteLine("Opción inválida.");
                        break;
                }

            } while (opcion != 0);
        }

        static void IngresarCalificaciones(double[] calificaciones)
        {
            for (int i = 0; i < calificaciones.Length; i++)
            {
                double nota;
                do
                {
                    Console.Write($"Ingrese la calificación del estudiante #{i + 1} (0-100): ");
                    nota = double.Parse(Console.ReadLine());
                } while (nota < 0 || nota > 100);

                calificaciones[i] = nota;
            }
        }

        static void MostrarCalificaciones(double[] calificaciones)
        {
            Console.WriteLine("\nCalificaciones de los estudiantes:");
            for (int i = 0; i < calificaciones.Length; i++)
            {
                Console.WriteLine($"Estudiante #{i + 1}: {calificaciones[i]}");
            }
        }

        static void CalcularEstadisticas(double[] calificaciones)
        {
            double suma = 0;
            double max = calificaciones[0];
            double min = calificaciones[0];
            int aprobados = 0;

            foreach (double cal in calificaciones)
            {
                suma += cal;

                if (cal > max)
                    max = cal;

                if (cal < min)
                    min = cal;

                if (cal >= 60)
                    aprobados++;
            }

            double promedio = suma / calificaciones.Length;

            Console.WriteLine($"\nPromedio: {promedio:F2}");
            Console.WriteLine($"Calificación más alta: {max}");
            Console.WriteLine($"Calificación más baja: {min}");
            Console.WriteLine($"Estudiantes aprobados: {aprobados}");
            Console.WriteLine($"Estudiantes reprobados: {calificaciones.Length - aprobados}");
        }

        static void OrdenarCalificaciones(double[] calificaciones)
        {
            Array.Sort(calificaciones);
            Console.WriteLine("\nCalificaciones ordenadas en forma ascendente:");
            foreach (double cal in calificaciones)
            {
                Console.Write(cal + " ");
            }
            Console.WriteLine();
        }

        static void MostrarDistribucionRangos(double[] calificaciones)
        {
            int reprobado = 0, suficiente = 0, bien = 0, notable = 0, excelente = 0;

            foreach (double cal in calificaciones)
            {
                if (cal < 60)
                    reprobado++;
                else if (cal <= 69)
                    suficiente++;
                else if (cal <= 79)
                    bien++;
                else if (cal <= 89)
                    notable++;
                else
                    excelente++;
            }

            Console.WriteLine("\nDistribución por rangos:");
            Console.WriteLine($"0-59 (Reprobado): {reprobado}");
            Console.WriteLine($"60-69 (Suficiente): {suficiente}");
            Console.WriteLine($"70-79 (Bien): {bien}");
            Console.WriteLine($"80-89 (Notable): {notable}");
            Console.WriteLine($"90-100 (Excelente): {excelente}");
        }
    }
}
