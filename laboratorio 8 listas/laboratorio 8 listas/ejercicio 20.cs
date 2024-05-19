

using System;
using System.Collections.Generic;
using System.Linq;

public class Funciones
{
    public static bool EsPalindromo(string palabra)
    {
        return palabra.SequenceEqual(palabra.Reverse());
    }

    public static List<string> PalindromosConLongitudOrdenados(HashSet<string> conjunto, int longitud)
    {
        return conjunto.Where(p => EsPalindromo(p) && p.Length == longitud).OrderBy(p => p).ToList();
    }

    public static void Main()
    {
        var conjuntoPalabras = new HashSet<string> { "radar", "nivel", "sometemos", "hola", "palabra" };
        var palindromosOrdenados = PalindromosConLongitudOrdenados(conjuntoPalabras, 5);
        Console.WriteLine(string.Join(", ", palindromosOrdenados));  // Salida: nivel, radar
    }
}


