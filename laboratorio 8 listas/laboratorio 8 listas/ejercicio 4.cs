
using System;
using System.Collections.Generic;
using System.Linq;

public class Funciones
{
    public static HashSet<int> InterseccionConjuntos(HashSet<int> conjunto1, HashSet<int> conjunto2)
    {
        return new HashSet<int>(conjunto1.Intersect(conjunto2));
    }

    public static void Main()
    {
        var conjunto1 = new HashSet<int> { 1, 2, 3, 4 };
        var conjunto2 = new HashSet<int> { 3, 4, 5, 6 };
        var interseccion = InterseccionConjuntos(conjunto1, conjunto2);
        Console.WriteLine(string.Join(", ", interseccion));  // Salida: 3, 4
    }
}


