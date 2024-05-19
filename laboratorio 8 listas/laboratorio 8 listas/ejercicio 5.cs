

 System;
using System.Collections.Generic;
using System.Linq;

public class Funciones
{
    public static HashSet<int> DiferenciaConjuntos(HashSet<int> conjunto1, HashSet<int> conjunto2)
    {
        return new HashSet<int>(conjunto1.Except(conjunto2));
    }

    public static void Main()
    {
        var conjunto1 = new HashSet<int> { 1, 2, 3, 4 };
        var conjunto2 = new HashSet<int> { 3, 4, 5, 6 };
        var diferencia = DiferenciaConjuntos(conjunto1, conjunto2);
        Console.WriteLine(string.Join(", ", diferencia));  // Salida: 1, 2
    }
}

