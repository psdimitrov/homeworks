using System;
using System.Linq;

class MaxSum
{
    static void Main()
    {
        int[] dimensions = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int n = dimensions[0];
        int m = dimensions[1];
        int[,] matrix = new int[n, m];

        for (int i = 0; i < n; i++)
        {
            int[] inputline = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            for (int j = 0; j < m; j++)
            {
                matrix[i, j] = inputline[j];
            }
        }

        // Find the maximal sum platform of size 3 x 3
        int bestSum = int.MinValue;
        int bestRow = 0;
        int bestCol = 0;
        for (int row = 0; row < matrix.GetLength(0) - 2; row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - 2; col++)
            {
                int sum = 0;
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        sum += matrix[row + i, col + j];
                    }
                }
                if (sum > bestSum)
                {
                    bestSum = sum;
                    bestRow = row;
                    bestCol = col;
                }
            }
        }

        // Print the result
        Console.WriteLine("Sum = {0}", bestSum);
        Console.WriteLine("{0} {1} {2}", matrix[bestRow, bestCol], matrix[bestRow, bestCol + 1], matrix[bestRow, bestCol + 2]);
        Console.WriteLine("{0} {1} {2}", matrix[bestRow + 1, bestCol], matrix[bestRow + 1, bestCol + 1], matrix[bestRow + 1, bestCol + 2]);
        Console.WriteLine("{0} {1} {2}", matrix[bestRow + 2, bestCol], matrix[bestRow + 2, bestCol + 1], matrix[bestRow + 2, bestCol + 2]);
        
    }
}

