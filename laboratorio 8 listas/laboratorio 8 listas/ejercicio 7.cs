
using System;
using System.Collections.Generic;
using System.Linq;

public class Funciones
{
    public static HashSet<HashSet<string>> EncontrarAnagramas(HashSet<string> conjunto)
    {
        var anagramas = new Dictionary<string, HashSet<string>>();
        foreach (var palabra in conjunto)
        {
            var clave = new string(palabra.OrderBy(c => c).ToArray());
            if (!anagramas.ContainsKey(clave))
            {
                anagramas[clave] = new HashSet<string>();
            }
            anagramas[clave].Add(palabra);
        }
        return new HashSet<HashSet<string>>(anagramas.Values.Where(grupo => grupo.Count > 1));
    }

    public static void Main()
    {
        var conjuntoPalabras = new HashSet<string> { "amor", "roma", "mora", "ramo", "perro", "ropa" };
        var anagramas = EncontrarAnagramas(conjuntoPalabras);
        foreach (var grupo in anagramas)
        {
            Console.WriteLine(string.Join(", ", grupo));  // Salida: amor, roma, mora, ramo
        }
    }
}

