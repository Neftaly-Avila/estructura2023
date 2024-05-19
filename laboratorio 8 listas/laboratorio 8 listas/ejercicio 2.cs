

using System;
using System.Collections.Generic;
using System.Linq;

public class Funciones
{
    public static HashSet<string> PalabrasConLetra(HashSet<string> conjunto, char letra)
    {
        return new HashSet<string>(conjunto.Where(p => p.StartsWith(letra.ToString())));
    }

    public static void Main()
    {
        var conjuntoPalabras = new HashSet<string> { "manzana", "mango", "pera", "melón", "platano" };
        var palabras = PalabrasConLetra(conjuntoPalabras, 'm');
        Console.WriteLine(string.Join(", ", palabras));  // Salida: manzana, mango, melón
    }
}


