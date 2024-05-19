
using System;
using System.Collections.Generic;
using System.Linq;

public class Funciones
{
    public static bool EsPalindromo(string palabra)
    {
        return palabra.SequenceEqual(palabra.Reverse());
    }

    public static List<string> PalindromosOrdenadosAscendente(HashSet<string> conjunto)
    {
        return conjunto.Where(EsPalindromo).OrderBy(p => p).ToList();
    }

    public static void Main()
    {
        var conjuntoPalabras = new HashSet<string> { "radar", "nivel", "sometemos", "hola", "palabra" };
        var palindromosOrdenados = PalindromosOrdenadosAscendente(conjuntoPalabras);
        Console.WriteLine(string.Join(", ", palindromosOrdenados));  // Salida: nivel, radar, sometemos
    }
}

