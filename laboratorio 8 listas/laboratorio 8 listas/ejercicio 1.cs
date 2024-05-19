
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

    public static HashSet<int> ObtenerPrimos(HashSet<int> conjunto)
    {
        return new HashSet<int>(conjunto.Where(EsPrimo));
    }

    public static void Main()
    {
        var conjuntoNumeros = new HashSet<int> { 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        var primos = ObtenerPrimos(conjuntoNumeros);
        Console.WriteLine(string.Join(", ", primos));  // Salida: 2, 3, 5, 7
    }
}




