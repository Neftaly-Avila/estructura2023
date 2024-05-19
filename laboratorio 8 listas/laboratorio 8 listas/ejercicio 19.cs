

using System;
using System.Collections.Generic;
using System.Linq;

public class Funciones
{
    public static List<int> UnicosOrdenadosAscendente(IEnumerable<int> conjunto)
    {
        return conjunto.GroupBy(num => num).Where(g => g.Count() == 1).Select(g => g.Key).OrderBy(num => num).ToList();
    }

    public static void Main()
    {
        var conjuntoNumeros = new List<int> { 5, 3, 8, 1, 2, 3, 2 };
        var unicosOrdenados = UnicosOrdenadosAscendente(conjuntoNumeros);
        Console.WriteLine(string.Join(", ", unicosOrdenados));  // Salida: 1, 5, 8
    }
}

