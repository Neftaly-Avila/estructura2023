
using System;
using System.Collections.Generic;
using System.Linq;

public class Funciones
{
    public static HashSet<string> PalabrasConLetraDeterminada(HashSet<string> conjunto, char letra)
    {
        return new HashSet<string>(conjunto.Where(p => p.Contains(letra)));
    }

    public static void Main()
    {
        var conjuntoPalabras = new HashSet<string> { "manzana", "mango", "pera", "melón", "plátano" };
        var palabras = PalabrasConLetraDeterminada(conjuntoPalabras, 'a');
        Console.WriteLine(string.Join(", ", palabras));  // Salida: manzana, mango, pera, plátano
    }
}


