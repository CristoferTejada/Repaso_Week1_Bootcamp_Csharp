namespace Week2_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("SISTEMA DE CALIFICACIONES");
            Console.WriteLine("=========================\n");

            // 1. Declarar el array de calificaciones
            double[] calificaciones = new double[10];

            // 2. Ingresar las calificaciones
            IngresarCalificaciones(calificaciones);

            int opcion;
            do
            {
                // Menú de opciones
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
