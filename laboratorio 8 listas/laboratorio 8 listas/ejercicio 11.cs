

using System;
using System.Collections.Generic;
using System.Linq;

public class Funciones
{
    public static List<int> OrdenadosAscendente(HashSet<int> conjunto)
    {
        return conjunto.OrderBy(num => num).ToList();
    }

    public static void Main()
    {
        var conjuntoNumeros = new HashSet<int> { 5, 3, 8, 1, 2 };
        var ordenados = OrdenadosAscendente(conjuntoNumeros);
        Console.WriteLine(string.Join(", ", ordenados));  // Salida: 1, 2, 3, 5, 8
    }
}

