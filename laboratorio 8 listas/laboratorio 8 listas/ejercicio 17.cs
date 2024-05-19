
using System;
using System.Collections.Generic;
using System.Linq;

public class Funciones
{
    public static List<string> PalabrasConLongitudOrdenadas(HashSet<string> conjunto, int longitud)
    {
        return conjunto.Where(p => p.Length == longitud).OrderBy(p => p).ToList();
    }

    public static void Main()
    {
        var conjuntoPalabras = new HashSet<string> { "manzana", "pera", "uva", "mango", "plátano" };
        var palabrasOrdenadas = PalabrasConLongitudOrdenadas(conjuntoPalabras, 4);
        Console.WriteLine(string.Join(", ", palabrasOrdenadas));  // Salida: mango, pera
    }
}


