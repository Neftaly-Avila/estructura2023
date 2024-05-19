// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// https://chatgpt.com/?oai-dm=1&model=gpt-4o

using System;

class Program
{
    static void Main()
    {
        int dim1 = 2;
        int dim2 = 2;
        int dim3 = 2;
        int dim4 = 2;

        double[,,,] matriz = new double[dim1, dim2, dim3, dim4];

        for (int i = 0; i < dim1; i++)
        {
            for (int j = 0; j < dim2; j++)
            {
                for (int k = 0; k < dim3; k++)
                {
                    for (int l = 0; l < dim4; l++)
                    {
                        matriz[i, j, k, l] = i + j + k + l;
                    }
                }
            }
        }

        // Calcular la suma y el promedio
        double suma = 0;
        int totalElementos = dim1 * dim2 * dim3 * dim4;

        for (int i = 0; i < dim1; i++)
        {
            for (int j = 0; j < dim2; j++)
            {
                for (int k = 0; k < dim3; k++)
                {
                    for (int l = 0; l < dim4; l++)
                    {
                        suma += matriz[i, j, k, l];
                    }
                }
            }
        }

        double promedio = suma / totalElementos;

        Console.WriteLine($"La suma de los elementos es: {suma}");
        Console.WriteLine($"El promedio de los elementos es: {promedio}");
    }
}




