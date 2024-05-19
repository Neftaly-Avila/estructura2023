
using System;
using System.Collections.Generic;
using System.Linq;

public class Funciones
{
    public static bool EsPrimo(int num)
    {
        if (num <= 1)
            return false;
        for (int i = 2; i <= Math.Sqrt(num); i++)
        {
            if (num % i == 0)
                return false;
        }
        return true;
    }

    public static List<int> PrimosOrdenadosAscendente(HashSet<int> conjunto)
    {
        return conjunto.Where(EsPrimo).OrderBy(num => num).ToList();
    }

    public static void Main()
    {
        var conjuntoNumeros = new HashSet<int> { 10, 3, 5, 2, 8, 7 };
        var primosOrdenados = PrimosOrdenadosAscendente(conjuntoNumeros);
        Console.WriteLine(string.Join(", ", primosOrdenados));  // Salida: 2, 3, 5, 7
    }
}

