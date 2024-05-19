

using System;
using System.Collections.Generic;
using System.Linq;

public class Funciones
{
    public static List<string> PalabrasConLetraOrdenadasDescendente(HashSet<string> conjunto, char letra)
    {
        return conjunto.Where(p => p.Contains(letra)).OrderByDescending(p => p).ToList();
    }

    public static void Main()
    {
        var conjuntoPalabras = new HashSet<string> { "manzana", "mango", "pera", "melón", "plátano" };
        var palabrasOrdenadas = PalabrasConLetraOrdenadasDescendente(conjuntoPalabras, 'a');
        Console.WriteLine(string.Join(", ", palabrasOrdenadas));  // Salida: plátano, pera, mango, manzana
    }
}

