// ejercicio 1


class Program
{
    static void Main(string[] args)
    {
        PrintEvenNumbers(1);
    }

    static void PrintEvenNumbers(int n)
    {
        if (n <= 100)
        {
            if (n % 2 == 0)
            {
                Console.WriteLine(n);
            }
            PrintEvenNumbers(n + 1);
        }
    }
}




// ejercicio 2



using System;

class Program
{
    static void Main(string[] args)
    {
        int n = 10;
        Console.WriteLine("La suma de los números del 1 al " + n + " es: " + SumarNumeros(1, n));
    }

    static int SumarNumeros(int inicio, int n)
    {
        if (inicio == n)
        {
            return n;
        }
        else
        {
            return inicio + SumarNumeros(inicio + 1, n);
        }
    }
}

//ejercicio 3


using System;

class Program
{
    static void Main(string[] args)
    {
        int n = 5;
        ImprimirPiramide(1, n);
    }

    static void ImprimirPiramide(int inicio, int n)
    {
        if (inicio <= n)
        {
            ImprimirLinea(inicio);
            ImprimirPiramide(inicio + 1, n);
        }
    }

    static void ImprimirLinea(int num)
    {
        if (num == 0)
            return;

        ImprimirLinea(num - 1);
        Console.Write(num + " ");
    }
}


//ejercicio 4


using System;

class Program
{
    static void Main(string[] args)
    {
        int n = 5;
        ImprimirPiramideInvertida(n);
    }

    static void ImprimirPiramideInvertida(int n)
    {
        ImprimirLineaInvertida(n);
        if (n > 1)
        {
            ImprimirPiramideInvertida(n - 1);
        }
    }

    static void ImprimirLineaInvertida(int num)
    {
        if (num == 0)
            return;

        Console.Write(num + " ");
        ImprimirLineaInvertida(num - 1);
    }
}


//ejercicio 5

using System;

class Program
{
    static void Main(string[] args)
    {
        int n = 5;
        ImprimirTablaMultiplicar(n, 1);
    }

    static void ImprimirTablaMultiplicar(int n, int multiplicador)
    {
        if (multiplicador <= 10)
        {
            Console.WriteLine($"{n} x {multiplicador} = {n * multiplicador}");
            ImprimirTablaMultiplicar(n, multiplicador + 1);
        }
    }
}


//ejercicio 6


using System;

class Program
{
    static void Main(string[] args)
    {
        // Crear una matriz
        double[,] matriz = new double[3, 3];

        // Asignar valores 
        matriz[0, 0] = 1.5;
        matriz[0, 1] = 2.8;
        matriz[0, 2] = 3.9;
        matriz[1, 0] = 4.2;
        matriz[1, 1] = 5.6;
        matriz[1, 2] = 6.1;
        matriz[2, 0] = 7.3;
        matriz[2, 1] = 8.4;
        matriz[2, 2] = 9.7;

        // Imprimir la matriz
        Console.WriteLine("Matriz de números reales:");
        ImprimirMatriz(matriz);
    }

    static void ImprimirMatriz(double[,] matriz)
    {
        int filas = matriz.GetLength(0);
        int columnas = matriz.GetLength(1);

        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                Console.Write(matriz[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}


//ejercicio 7

using System;

public class NumeroComplejo
{
    public double ParteReal { get; set; }
    public double ParteImaginaria { get; set; }

    public NumeroComplejo(double real, double imaginaria)
    {
        ParteReal = real;
        ParteImaginaria = imaginaria;
    }

    public override string ToString()
    {
        return $"{ParteReal} + {ParteImaginaria}i";
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Crea una matriz de números complejos de tamaño 2x2
        NumeroComplejo[,] matriz = new NumeroComplejo[2, 2];

        // Asignar valores a la matriz
        matriz[0, 0] = new NumeroComplejo(1.5, 2.8);
        matriz[0, 1] = new NumeroComplejo(3.9, 4.2);
        matriz[1, 0] = new NumeroComplejo(5.6, 6.1);
        matriz[1, 1] = new NumeroComplejo(7.3, 8.4);

        // Imprimir la matriz
        Console.WriteLine("Matriz de números complejos:");
        ImprimirMatriz(matriz);
    }

    static void ImprimirMatriz(NumeroComplejo[,] matriz)
    {
        int filas = matriz.GetLength(0);
        int columnas = matriz.GetLength(1);

        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                Console.Write(matriz[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}


//ejercicio 8


using System;

class Program
{
    static void Main(string[] args)
    {   
        int[,][] matriz = new int[2, 2][];

        matriz[0, 0] = new int[] { 1, 2, 3 };
        matriz[0, 1] = new int[] { 4, 5, 6 };
        matriz[1, 0] = new int[] { 7, 8, 9 };
        matriz[1, 1] = new int[] { 10, 11, 12 };

        Console.WriteLine("Matriz de matrices:");
        ImprimirMatriz(matriz);
    }

    static void ImprimirMatriz(int[,][] matriz)
    {
        int filas = matriz.GetLength(0);
        int columnas = matriz.GetLength(1);

        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                ImprimirArray(matriz[i, j]);
                Console.Write("\t");
            }
            Console.WriteLine();
        }
    }

    static void ImprimirArray(int[] array)
    {
        foreach (int num in array)
        {
            Console.Write(num + " ");
        }
    }
}

//ejercicio 9



using System;

class Program
{
    static void Main(string[] args)
    {

        int[,] matriz = new int[,]
        {
            { 1, 2, 3, 4, 5 },
            { 6, 7, 8, 9, 10 },
            { 11, 12, 13, 14, 15 },
            { 16, 17, 18, 19, 20 },
            { 21, 22, 23, 24, 25 }
        };


        int filas = matriz.GetLength(0);
        int columnas = matriz.GetLength(1);


        int filaCentral = filas / 2;
        int columnaCentral = columnas / 2;


        int elementoCentral = matriz[filaCentral, columnaCentral];

     
        Console.WriteLine("El elemento central de la matriz es: " + elementoCentral);
    }
}


//ejercicio 10


using System;

class Program
{
    static void Main(string[] args)
    {
        int[,] matriz1 = { { 1, 2 }, { 3, 4 }, { 5, 6 } };
        int[,] matriz2 = { { 7, 8, 9 }, { 10, 11, 12 } };

        try
        {
            int[,] resultado = SumarMatrices(matriz1, matriz2);
            ImprimirMatriz(resultado);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    static int[,] SumarMatrices(int[,] matriz1, int[,] matriz2)
    {
        if (matriz1.GetLength(0) != matriz2.GetLength(0) || matriz1.GetLength(1) != matriz2.GetLength(1))
        {
            throw new ArgumentException("Las matrices no tienen el mismo tamaño y no se pueden sumar.");
        }

        int filas = matriz1.GetLength(0);
        int columnas = matriz1.GetLength(1);
        int[,] resultado = new int[filas, columnas];

        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                resultado[i, j] = matriz1[i, j] + matriz2[i, j];
            }
        }

        return resultado;
    }

    static void ImprimirMatriz(int[,] matriz)
    {
        int filas = matriz.GetLength(0);
        int columnas = matriz.GetLength(1);

        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                Console.Write(matriz[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}


//ejercicio 11


using System;

class Program
{
    static void Main(string[] args)
    {
        int[,] matriz = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

        
        int[,] resultado = MultiplicarMatrizPorNumero(matriz, 2);

        ImprimirMatriz(resultado);
    }

    static int[,] MultiplicarMatrizPorNumero(int[,] matriz, int numero)
    {
        int filas = matriz.GetLength(0);
        int columnas = matriz.GetLength(1);
        int[,] resultado = new int[filas, columnas];

        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                resultado[i, j] = matriz[i, j] * numero;
            }
        }

        return resultado;
    }

    static void ImprimirMatriz(int[,] matriz)
    {
        int filas = matriz.GetLength(0);
        int columnas = matriz.GetLength(1);

        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                Console.Write(matriz[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}


//ejercicio 12


using System;

class Program
{
    static void Main(string[] args)
    {
        int[,] matriz = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

        double media = CalcularMediaMatriz(matriz);

        Console.WriteLine("La media de los elementos de la matriz es: " + media);
    }

    static double CalcularMediaMatriz(int[,] matriz)
    {
        int filas = matriz.GetLength(0);
        int columnas = matriz.GetLength(1);
        int suma = 0;
        int cantidadElementos = filas * columnas;

        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                suma += matriz[i, j];
            }
        }

        double media = (double)suma / cantidadElementos;
        return media;
    }
}



//ejercicio de matrices:


//ejercicio 1
using System;

class Program
{
    static void Main(string[] args)
    {
        int[,] matriz = GenerarMatrizAleatoria(100, 100);
        Console.WriteLine("Matriz generada:");
        ImprimirMatriz(matriz);
    }

    static int[,] GenerarMatrizAleatoria(int filas, int columnas)
    {
        Random rnd = new Random();
        int[,] matriz = new int[filas, columnas];
        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                matriz[i, j] = rnd.Next(100); 
            }
        }
        return matriz;
    }

    static void ImprimirMatriz(int[,] matriz)
    {
        int filas = matriz.GetLength(0);
        int columnas = matriz.GetLength(1);
        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                Console.Write(matriz[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}

//ejercicio 2
using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int[,] matriz = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

        double media = CalcularMedia(matriz);
        Console.WriteLine("Media: " + media);

        double mediana = CalcularMediana(matriz);
        Console.WriteLine("Mediana: " + mediana);

        double desviacionEstandar = CalcularDesviacionEstandar(matriz);
        Console.WriteLine("Desviación estándar: " + desviacionEstandar);
    }

    static double CalcularMedia(int[,] matriz)
    {
        int filas = matriz.GetLength(0);
        int columnas = matriz.GetLength(1);
        double suma = 0;
        int cantidadElementos = filas * columnas;

        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                suma += matriz[i, j];
            }
        }

        return suma / cantidadElementos;
    }

    static double CalcularMediana(int[,] matriz)
    {
        int filas = matriz.GetLength(0);
        int columnas = matriz.GetLength(1);
        int cantidadElementos = filas * columnas;
        int[] elementos = new int[cantidadElementos];

        int k = 0;
        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                elementos[k++] = matriz[i, j];
            }
        }

        Array.Sort(elementos);

        if (cantidadElementos % 2 == 0)
        {
            return (elementos[cantidadElementos / 2 - 1] + elementos[cantidadElementos / 2]) / 2.0;
        }
        else
        {
            return elementos[cantidadElementos / 2];
        }
    }

    static double CalcularDesviacionEstandar(int[,] matriz)
    {
        int filas = matriz.GetLength(0);
        int columnas = matriz.GetLength(1);
        double media = CalcularMedia(matriz);
        double sumaCuadrados = 0;
        int cantidadElementos = filas * columnas;

        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                double diferencia = matriz[i, j] - media;
                sumaCuadrados += diferencia * diferencia;
            }
        }

        return Math.Sqrt(sumaCuadrados / cantidadElementos);
    }
}


//ejercicio 3

using System;

class Program
{
    static void Main(string[] args)
    {
        int[,] matriz = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

        int maximo = EncontrarMaximo(matriz);
        Console.WriteLine("El elemento máximo de la matriz es: " + maximo);
    }

    static int EncontrarMaximo(int[,] matriz)
    {
        int filas = matriz.GetLength(0);
        int columnas = matriz.GetLength(1);
        int maximo = matriz[0, 0];

        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                if (matriz[i, j] > maximo)
                {
                    maximo = matriz[i, j];
                }
            }
        }

        return maximo;
    }
}


//ejercicio 4

using System;

class Program
{
    static void Main(string[] args)
    {
        int[,] matriz = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

        int sumaMaxima;
        int filaInicio, filaFin, columnaInicio, columnaFin;
        EncontrarSubmatrizMaxima(matriz, out sumaMaxima, out filaInicio, out filaFin, out columnaInicio, out columnaFin);

        Console.WriteLine("La submatriz de mayor suma es:");
        for (int i = filaInicio; i <= filaFin; i++)
        {
            for (int j = columnaInicio; j <= columnaFin; j++)
            {
                Console.Write(matriz[i, j] + "\t");
            }
            Console.WriteLine();
        }
        Console.WriteLine("La suma de los elementos de la submatriz es: " + sumaMaxima);
    }

    static void EncontrarSubmatrizMaxima(int[,] matriz, out int sumaMaxima, out int filaInicio, out int filaFin, out int columnaInicio, out int columnaFin)
    {
        int filas = matriz.GetLength(0);
        int columnas = matriz.GetLength(1);
        sumaMaxima = int.MinValue;
        filaInicio = filaFin = columnaInicio = columnaFin = 0;

        for (int iInicio = 0; iInicio < filas; iInicio++)
        {
            for (int jInicio = 0; jInicio < columnas; jInicio++)
            {
                for (int iFin = iInicio; iFin < filas; iFin++)
                {
                    for (int jFin = jInicio; jFin < columnas; jFin++)
                    {
                        int sumaSubmatriz = 0;
                        for (int i = iInicio; i <= iFin; i++)
                        {
                            for (int j = jInicio; j <= jFin; j++)
                            {
                                sumaSubmatriz += matriz[i, j];
                            }
                        }

                        if (sumaSubmatriz > sumaMaxima)
                        {
                            sumaMaxima = sumaSubmatriz;
                            filaInicio = iInicio;
                            filaFin = iFin;
                            columnaInicio = jInicio;
                            columnaFin = jFin;
                        }
                    }
                }
            }
        }
    }
}


//ejercicio 5

using System;

class Program
{
    static void Main(string[] args)
    {
        double[,] matriz1 = {
            {1, 2},
            {3, 4},
            {5, 6}
        };

        double[,] matriz2 = {
            {7, 8},
            {9, 10},
            {11, 12}
        };

        double[,] covarianza = CalcularMatrizCovarianza(matriz1, matriz2);
        Console.WriteLine("La matriz de covarianza es:");
        ImprimirMatriz(covarianza);
    }

    static double[,] CalcularMatrizCovarianza(double[,] matriz1, double[,] matriz2)
    {
        int filas = matriz1.GetLength(0);
        int columnas = matriz1.GetLength(1);
        double[,] covarianza = new double[columnas, columnas];

        for (int i = 0; i < columnas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                double cov = 0;
                for (int k = 0; k < filas; k++)
                {
                    cov += (matriz1[k, i] - CalcularMedia(matriz1, i)) * (matriz2[k, j] - CalcularMedia(matriz2, j));
                }
                covarianza[i, j] = cov / filas;
            }
        }

        return covarianza;
    }

    static double CalcularMedia(double[,] matriz, int columna)
    {
        int filas = matriz.GetLength(0);
        double suma = 0;
        for (int i = 0; i < filas; i++)
        {
            suma += matriz[i, columna];
        }
        return suma / filas;
    }

    static void ImprimirMatriz(double[,] matriz)
    {
        int filas = matriz.GetLength(0);
        int columnas = matriz.GetLength(1);

        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                Console.Write(matriz[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}
