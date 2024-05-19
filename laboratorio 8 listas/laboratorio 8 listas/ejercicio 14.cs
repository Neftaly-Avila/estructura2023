using System;
using System.Collections.Generic;
using System.Linq;

public class Funciones
{
    public static HashSet<int> NumerosNoDuplicados(IEnumerable<int> conjunto)
    {
        return new HashSet<int>(conjunto.GroupBy(num => num).Where(g => g.Count() == 1).Select(g => g.Key));
    }

    public static void Main()
    {
        var conjuntoNumeros = new List<int> { 1, 2, 2, 3, 4, 4, 4, 5 };
        var noDuplicados = NumerosNoDuplicados(conjuntoNumeros);
        Console.WriteLine(string.Join(", ", noDuplicados));  // Salida: 1, 3, 5
    }
}


