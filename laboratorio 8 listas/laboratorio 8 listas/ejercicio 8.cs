
using System;
using System.Collections.Generic;
using System.Linq;

public class Funciones
{
    public static HashSet<string> EncontrarPalindromos(HashSet<string> conjunto)
    {
        return new HashSet<string>(conjunto.Where(p => p.SequenceEqual(p.Reverse())));
    }

    public static void Main()
    {
        var conjuntoPalabras = new HashSet<string> { "radar", "nivel", "sometemos", "hola", "palabra" };
        var palindromos = EncontrarPalindromos(conjuntoPalabras);
        Console.WriteLine(string.Join(", ", palindromos));  // Salida: radar, nivel, sometemos
    }
}

