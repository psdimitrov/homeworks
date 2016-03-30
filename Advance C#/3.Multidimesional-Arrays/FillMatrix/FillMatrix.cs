using System;
using System.Collections.Generic;
using System.Linq;

class FillMatrix
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[,] matrix = new int[n, n];

        FillMatrixA(matrix);
        PrintMatrix(matrix);
        FillMatrixB(matrix);
        PrintMatrix(matrix);
    }

    static void PrintMatrix(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write("{0,-3} ", matrix[i, j]);
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }

    static void FillMatrixA(int[,] matrix)
    {
        int number = 1;
        for (int i = 0; i < matrix.GetLength(1); i++)
        {
            for (int j = 0; j < matrix.GetLength(0); j++)
            {
                matrix[j, i] = number;
                number++;
            }
        }
    }
    static void FillMatrixB(int[,] matrix)
    {
        int number = 1;
        for (int i = 0; i < matrix.GetLength(1); i++)
        {
            for (int j = 0; j < matrix.GetLength(0); j++)
            {
                if (i % 2 == 0)
                {
                    matrix[j, i] = number;
                }
                else
                {
                    matrix[matrix.GetLength(0) - j -1, i] = number;
                }
                number++;
            }
        }
    }
}
