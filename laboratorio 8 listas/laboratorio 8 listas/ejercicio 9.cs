
using System;
using System.Collections.Generic;
using System.Linq;

public class Funciones
{
    public static HashSet<string> PalabrasConLongitud(HashSet<string> conjunto, int longitud)
    {
        return new HashSet<string>(conjunto.Where(p => p.Length == longitud));
    }

    public static void Main()
    {
        var conjuntoPalabras = new HashSet<string> { "manzana", "pera", "uva", "mango", "plátano" };
        var palabras = PalabrasConLongitud(conjuntoPalabras, 4);
        Console.WriteLine(string.Join(", ", palabras));  // Salida: pera, mango
    }
}


