namespace Week2_HashSet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("HASHSET<T> EN C#");
            Console.WriteLine("===============\n");

            // 1. Crear un HashSet
            Console.WriteLine("1. Creación e inicialización:");

            // Forma 1: Constructor vacío
            HashSet<int> numeros = new HashSet<int>();
            numeros.Add(1);
            numeros.Add(2);
            numeros.Add(3);

            // Forma 2: Inicialización con una colección existente
            int[] arrayNumeros = { 3, 4, 5, 6, 3 }; // Nota: el 3 está duplicado
            HashSet<int> otrosNumeros = new HashSet<int>(arrayNumeros);

            // Forma 3: Inicialización en línea
            HashSet<string> colores = new HashSet<string> { "Rojo", "Verde", "Azul", "Amarillo" };

            // 2. Mostrar elementos (los elementos duplicados se eliminan automáticamente)
            Console.WriteLine("\n2. Contenido de los HashSets:");

            Console.WriteLine("numeros:");
            foreach (int num in numeros)
                Console.Write($"{num} ");

            Console.WriteLine("\notrosNumeros (nota que el 3 duplicado se eliminó):");
            foreach (int num in otrosNumeros)
                Console.Write($"{num} ");

            Console.WriteLine("\ncolores:");
            foreach (string color in colores)
                Console.Write($"{color} ");

            // 3. Añadir elementos duplicados (serán ignorados)
            Console.WriteLine("\n\n3. Intentar añadir duplicados:");
            bool agregado = numeros.Add(2); // Intentar añadir un 2 de nuevo
            Console.WriteLine($"¿Se agregó el 2 duplicado? {agregado}");

            Console.WriteLine("numeros después de intentar añadir duplicado:");
            foreach (int num in numeros)
                Console.Write($"{num} ");

            // 4. Verificar si contiene un elemento
            Console.WriteLine("\n\n4. Verificar si contiene elementos:");
            bool contieneVerde = colores.Contains("Verde");
            bool contieneNegro = colores.Contains("Negro");
            Console.WriteLine($"¿Contiene 'Verde'? {contieneVerde}");
            Console.WriteLine($"¿Contiene 'Negro'? {contieneNegro}");

            // 5. Eliminar elementos
            Console.WriteLine("\n5. Eliminar elementos:");
            bool eliminado = colores.Remove("Amarillo");
            Console.WriteLine($"¿Se eliminó 'Amarillo'? {eliminado}");

            Console.WriteLine("colores después de eliminar 'Amarillo':");
            foreach (string color in colores)
                Console.Write($"{color} ");

            // 6. Operaciones de conjuntos
            Console.WriteLine("\n\n6. Operaciones de conjuntos:");

            // Unión: elementos que están en cualquiera de los conjuntos
            Console.WriteLine("\n6.1. Unión (UnionWith):");
            HashSet<int> conjuntoA = new HashSet<int> { 1, 2, 3, 4 };
            HashSet<int> conjuntoB = new HashSet<int> { 3, 4, 5, 6 };

            Console.WriteLine("Conjunto A original:");
            foreach (int num in conjuntoA)
                Console.Write($"{num} ");

            Console.WriteLine("\nConjunto B original:");
            foreach (int num in conjuntoB)
                Console.Write($"{num} ");

            // Realizar la unión (A ∪ B)
            conjuntoA.UnionWith(conjuntoB);

            Console.WriteLine("\nResultado de la unión (A ∪ B):");
            foreach (int num in conjuntoA)
                Console.Write($"{num} ");

            // Intersección: elementos que están en ambos conjuntos
            Console.WriteLine("\n\n6.2. Intersección (IntersectWith):");
            HashSet<int> conjuntoC = new HashSet<int> { 1, 2, 3, 4 };
            HashSet<int> conjuntoD = new HashSet<int> { 3, 4, 5, 6 };

            Console.WriteLine("Conjunto C original:");
            foreach (int num in conjuntoC)
                Console.Write($"{num} ");

            Console.WriteLine("\nConjunto D original:");
            foreach (int num in conjuntoD)
                Console.Write($"{num} ");

            // Realizar la intersección (C ∩ D)
            conjuntoC.IntersectWith(conjuntoD);

            Console.WriteLine("\nResultado de la intersección (C ∩ D):");
            foreach (int num in conjuntoC)
                Console.Write($"{num} ");

            // Diferencia: elementos en el primer conjunto pero no en el segundo
            Console.WriteLine("\n\n6.3. Diferencia (ExceptWith):");
            HashSet<int> conjuntoE = new HashSet<int> { 1, 2, 3, 4 };
            HashSet<int> conjuntoF = new HashSet<int> { 3, 4, 5, 6 };

            Console.WriteLine("Conjunto E original:");
            foreach (int num in conjuntoE)
                Console.Write($"{num} ");

            Console.WriteLine("\nConjunto F original:");
            foreach (int num in conjuntoF)
                Console.Write($"{num} ");

            // Realizar la diferencia (E - F)
            conjuntoE.ExceptWith(conjuntoF);

            Console.WriteLine("\nResultado de la diferencia (E - F):");
            foreach (int num in conjuntoE)
                Console.Write($"{num} ");

            // Diferencia simétrica: elementos en uno u otro conjunto, pero no en ambos
            Console.WriteLine("\n\n6.4. Diferencia simétrica (SymmetricExceptWith):");
            HashSet<int> conjuntoG = new HashSet<int> { 1, 2, 3, 4 };
            HashSet<int> conjuntoH = new HashSet<int> { 3, 4, 5, 6 };

            Console.WriteLine("Conjunto G original:");
            foreach (int num in conjuntoG)
                Console.Write($"{num} ");

            Console.WriteLine("\nConjunto H original:");
            foreach (int num in conjuntoH)
                Console.Write($"{num} ");

            // Realizar la diferencia simétrica (G △ H)
            conjuntoG.SymmetricExceptWith(conjuntoH);

            Console.WriteLine("\nResultado de la diferencia simétrica (G △ H):");
            foreach (int num in conjuntoG)
                Console.Write($"{num} ");

            // 7. Verificar relaciones entre conjuntos
            Console.WriteLine("\n\n7. Verificar relaciones entre conjuntos:");

            HashSet<int> conjuntoI = new HashSet<int> { 1, 2, 3 };
            HashSet<int> conjuntoJ = new HashSet<int> { 1, 2, 3, 4, 5 };
            HashSet<int> conjuntoK = new HashSet<int> { 1, 2, 3 };
            HashSet<int> conjuntoL = new HashSet<int> { 4, 5, 6 };

            // IsSubsetOf - ¿I es subconjunto de J?
            bool esSubconjunto = conjuntoI.IsSubsetOf(conjuntoJ);
            Console.WriteLine($"¿conjuntoI es subconjunto de conjuntoJ? {esSubconjunto}");

            // IsSupersetOf - ¿J es superconjunto de I?
            bool esSuperconjunto = conjuntoJ.IsSupersetOf(conjuntoI);
            Console.WriteLine($"¿conjuntoJ es superconjunto de conjuntoI? {esSuperconjunto}");

            // SetEquals - ¿I y K son iguales?
            bool sonIguales = conjuntoI.SetEquals(conjuntoK);
            Console.WriteLine($"¿conjuntoI y conjuntoK son iguales? {sonIguales}");

            // Overlaps - ¿I y L tienen elementos en común?
            bool tienenElementosComunes = conjuntoI.Overlaps(conjuntoL);
            Console.WriteLine($"¿conjuntoI y conjuntoL tienen elementos en común? {tienenElementosComunes}");
        }
    }
}
