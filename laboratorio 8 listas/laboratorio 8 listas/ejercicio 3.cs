
using System;
using System.Collections.Generic;
using System.Linq;

public class Funciones
{
    public static HashSet<int> DivisiblesPor(HashSet<int> conjunto, int divisor)
    {
        return new HashSet<int>(conjunto.Where(num => num % divisor == 0));
    }

    public static void Main()
    {
        var conjuntoNumeros = new HashSet<int> { 10, 20, 25, 30, 35, 40 };
        var divisibles = DivisiblesPor(conjuntoNumeros, 5);
        Console.WriteLine(string.Join(", ", divisibles));  // Salida: 10, 20, 25, 30, 35, 40
    }
}



