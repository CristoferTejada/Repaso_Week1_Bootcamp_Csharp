namespace Week2_Collections_Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DICTIONARY<TKey, TValue> EN C#");
            Console.WriteLine("=============================\n");

            // 1. Creación e inicialización
            Console.WriteLine("1. Creación e inicialización:");

            // Forma 1: Constructor vacío
            Dictionary<string, int> edades = new Dictionary<string, int>();
            edades.Add("Juan", 25);
            edades.Add("María", 30);
            edades.Add("Carlos", 22);

            // Forma 2: Inicialización en línea
            Dictionary<string, string> capitales = new Dictionary<string, string>
            {
                { "España", "Madrid" },
                { "Francia", "París" },
                { "Italia", "Roma" }
             };

            // Forma 3: Inicialización con inicializadores de objeto
            Dictionary<int, string> codigos = new Dictionary<int, string>
            {
                [1] = "Uno",
                [2] = "Dos",
                [3] = "Tres"
            };

            // 2. Acceso a valores por clave
            Console.WriteLine("\n2. Acceso a valores por clave:");
            Console.WriteLine($"La edad de María es: {edades["María"]}");
            Console.WriteLine($"La capital de Italia es: {capitales["Italia"]}");
            Console.WriteLine($"El código 2 corresponde a: {codigos[2]}");

            // 3. Verificar si una clave existe
            Console.WriteLine("\n3. Verificar si una clave existe:");
            string persona = "Pedro";
            if (edades.ContainsKey(persona))
                Console.WriteLine($"La edad de {persona} es: {edades[persona]}");
            else
                Console.WriteLine($"No se encontró a {persona} en el diccionario");

            // 4. Acceso seguro con TryGetValue
            Console.WriteLine("\n4. Acceso seguro con TryGetValue:");
            string pais = "Portugal";
            if (capitales.TryGetValue(pais, out string capital))
                Console.WriteLine($"La capital de {pais} es: {capital}");
            else
                Console.WriteLine($"No se encontró el país {pais} en el diccionario");

            // 5. Modificar valores
            Console.WriteLine("\n5. Modificar valores:");

            // Modificar el valor de una clave existente
            edades["Juan"] = 26;
            Console.WriteLine($"La nueva edad de Juan es: {edades["Juan"]}");

            // Usar el método this[] también añade una clave si no existe
            edades["Pedro"] = 40;
            Console.WriteLine($"La edad de Pedro es: {edades["Pedro"]}");

            // 6. Eliminar elementos
            Console.WriteLine("\n6. Eliminar elementos:");
            bool eliminado = edades.Remove("Carlos");
            Console.WriteLine($"¿Se eliminó a Carlos? {eliminado}");

            // Verificar que se eliminó
            Console.WriteLine("Personas en el diccionario después de eliminar:");
            foreach (KeyValuePair<string, int> par in edades)
                Console.WriteLine($"{par.Key}: {par.Value}");

            // 7. Recorrer un diccionario
            Console.WriteLine("\n7. Recorrer un diccionario:");

            // Forma 1: Usando KeyValuePair
            Console.WriteLine("\n7.1. Usando KeyValuePair:");
            foreach (KeyValuePair<string, string> par in capitales)
                Console.WriteLine($"País: {par.Key}, Capital: {par.Value}");

            // Forma 2: Usando var (inferencia de tipos)
            Console.WriteLine("\n7.2. Usando var (inferencia de tipos):");
            foreach (var par in capitales)
                Console.WriteLine($"País: {par.Key}, Capital: {par.Value}");

            // Forma 3: Recorrer solo las claves
            Console.WriteLine("\n7.3. Recorrer solo las claves:");
            foreach (string key in capitales.Keys)
                Console.WriteLine($"País: {key}");

            // Forma 4: Recorrer solo los valores
            Console.WriteLine("\n7.4. Recorrer solo los valores:");
            foreach (string value in capitales.Values)
                Console.WriteLine($"Capital: {value}");

            // 8. Limpiar el diccionario
            Console.WriteLine("\n8. Limpiar el diccionario:");
            capitales.Clear();
            Console.WriteLine($"Número de elementos después de Clear(): {capitales.Count}");

            // 9. Uso avanzado con LINQ
            Console.WriteLine("\n9. Uso avanzado con LINQ:");

            // Crear un diccionario más grande para los ejemplos
            Dictionary<string, double> productos = new Dictionary<string, double>
            {
                { "Laptop", 899.99 },
                { "Teléfono", 499.99 },
                { "Tablet", 299.99 },
                { "Auriculares", 79.99 },
                { "Monitor", 249.99 },
                { "Teclado", 59.99 }
            };

            // Filtrar productos con precio mayor a 200
            Console.WriteLine("\n9.1. Filtrar productos con precio > 200:");
            var productosCostosos = productos.Where(p => p.Value > 200)
                                            .ToDictionary(p => p.Key, p => p.Value);

            foreach (var par in productosCostosos)
                Console.WriteLine($"{par.Key}: ${par.Value}");

            // Ordenar por precio (ascendente)
            Console.WriteLine("\n9.2. Productos ordenados por precio (ascendente):");
            var productosOrdenados = productos.OrderBy(p => p.Value);

            foreach (var par in productosOrdenados)
                Console.WriteLine($"{par.Key}: ${par.Value}");

            // 10. Diccionario con tipos complejos
            Console.WriteLine("\n10. Diccionario con tipos complejos:");

            Dictionary<int, Producto> inventario = new Dictionary<int, Producto>
             {
                    { 1001, new Producto { Nombre = "Portátil Gaming", Precio = 1299.99, Stock = 15 } },
                    { 1002, new Producto { Nombre = "Smartphone 5G", Precio = 799.99, Stock = 30 } },
                    { 1003, new Producto { Nombre = "Tablet Pro", Precio = 599.99, Stock = 10 } }
             };

            Console.WriteLine("Inventario de productos:");
            foreach (var par in inventario)
                Console.WriteLine($"ID: {par.Key}, Producto: {par.Value.Nombre}, Precio: ${par.Value.Precio}, Stock: {par.Value.Stock}");

            // 11. Uso útil: contador de frecuencias
            Console.WriteLine("\n11. Caso de uso: contador de frecuencias de palabras:");

            string texto = "Este es un ejemplo de texto para contar palabras. Este ejemplo muestra cómo contar la frecuencia de palabras en un texto.";
            string[] palabras = texto.ToLower().Split(new char[] { ' ', '.', ',', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, int> frecuencias = new Dictionary<string, int>();

            foreach (string palabra in palabras)
            {
                if (frecuencias.ContainsKey(palabra))
                    frecuencias[palabra]++;
                else
                    frecuencias[palabra] = 1;
            }

            Console.WriteLine("Frecuencia de palabras:");
            foreach (var par in frecuencias.OrderByDescending(p => p.Value))
                Console.WriteLine($"{par.Key}: {par.Value} veces");
        }

        // Clase auxiliar para el ejemplo
        class Producto
        {
            public string Nombre { get; set; }
            public double Precio { get; set; }
            public int Stock { get; set; }
        }

        class Libro
        {
            public string Nombre { get; set; }
            public double Precio { get; set; }
            public int Stock { get; set; }
        }
    }
}
