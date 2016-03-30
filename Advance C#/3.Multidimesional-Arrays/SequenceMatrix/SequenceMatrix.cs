using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SequenceMatrix
{
    static void Main()
    {
        Console.Write("Enter the number of the rows in your matrix: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter the number of the coloms in your matrix: ");
        int m = int.Parse(Console.ReadLine());

        string[,] matrix = new string[n, m];

        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < m; col++)
            {
                Console.WriteLine("Enter the string on position row[{0}], col[{1}]: ", row, col);
                matrix[row, col] = Console.ReadLine();
            }
        }
        int length = 1;
        int maxLength = 1;
        
        string element="";
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                int k = 0;
                length = 1;
                if (j != m - 1)
                {
                    while (matrix[i, j + k] == matrix[i, j + k + 1])
                    {
                        length++;
                        k++;
                        if ((j + k + 1) == m)
                        {
                            break;
                        }
                    }
                    if (length > maxLength)
                    {
                        maxLength = length;
                        element = matrix[i, j + k];
                    }
                    length = 1;
                    k = 0;
                }
                if (i != n - 1)
                {
                    while (matrix[i + k, j] == matrix[i + k + 1, j])
                    {
                        length++;
                        k++;
                        if ((i + k + 1) == n)
                        {
                            break;
                        }
                    }
                    if (length > maxLength)
                    {
                        maxLength = length;
                        element = matrix[i + k, j];
                    }
                    length = 1;
                    k = 0;
                }
                if (i != n - 1 && j != m - 1)
                {
                    while (matrix[i + k, j + k] == matrix[i + k + 1, j + k + 1])
                    {
                        length++;
                        k++;
                        if ((i + k + 1) == n || (j + k + 1) == m)
                        {
                            break;
                        }
                    }
                    if (length > maxLength)
                    {
                        maxLength = length;
                        element = matrix[i + k, j + k];
                    }
                    length = 1;
                    k = 0;
                }
                if (i != n - 1 && j != 0)
                {
                    while (matrix[i + k, j - k] == matrix[i + k + 1, j - k - 1])
                    {
                        length++;
                        k++;
                        if ((i + k + 1) == n || (j - k - 1) == -1)
                        {
                            break;
                        }

                    }
                    if (length > maxLength)
                    {
                        maxLength = length;
                        element = matrix[i + k, j - k];
                    }
                }
            }
        }
        Console.Write(element);
        for (int i = 0; i < maxLength-1; i++)
        {
            Console.Write(", {0}",element);
        }
        Console.WriteLine();
    }
}



