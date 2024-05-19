
using System;
using System.Collections.Generic;
using System.Linq;

public class Funciones
{
    public static List<int> OrdenadosDescendente(HashSet<int> conjunto)
    {
        return conjunto.OrderByDescending(num => num).ToList();
    }

    public static void Main()
    {
        var conjuntoNumeros = new HashSet<int> { 5, 3, 8, 1, 2 };
        var ordenados = OrdenadosDescendente(conjuntoNumeros);
        Console.WriteLine(string.Join(", ", ordenados));  // Salida: 8, 5, 3, 2, 1
    }
}

