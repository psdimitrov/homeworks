using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringMatrixRotation
{
    class StringMatrixRotation
    {
        static void Main()
        {
            List<List<char>> matrix = new List<List<char>>();
            string command = Console.ReadLine();
            int degrees = int.Parse(command.Trim(')').Substring(7));            
            int maxLength = 0;
            string line = Console.ReadLine();
            while (line != "END")
            {
                matrix.Add(new List<char>(line));                
                if (maxLength < line.Length)
                {
                    maxLength = line.Length;                    
                }
                line = Console.ReadLine();
            }
            if (matrix.Count > 0)
            {
                FillSpaces(maxLength, matrix);
                RotateMatrix(degrees, matrix);
            }
        }

        private static void RotateMatrix(int degrees, List<List<char>> matrix)
        {
            degrees = degrees % 360;
            List<List<char>> result = new List<List<char>>();
            switch (degrees)
            {
                case 0:
                    Print(matrix);
                    break;
                case 90:
                    RotateMatrix90(matrix, result);
                    Print(result);
                    break;
                case 180:
                    RotateMatrix180(matrix, result);
                    Print(result);
                    break;
                case 270:
                    RotateMatrix270(matrix, result);
                    Print(result);
                    break;                
            }
        }

        private static void Print(List<List<char>> matrix)
        {
            for (int i = 0; i < matrix.Count; i++)
            {
                Console.WriteLine(matrix[i].ToArray());
            }
        }

        private static void RotateMatrix270(List<List<char>> matrix, List<List<char>> result)
        {
            List<List<char>> temp = new List<List<char>>();
            RotateMatrix180(matrix, temp);
            RotateMatrix90(temp, result);
        }

        private static void RotateMatrix180(List<List<char>> matrix, List<List<char>> result)
        {
            List<List<char>> temp = new List<List<char>>();
            RotateMatrix90(matrix, temp);
            RotateMatrix90(temp, result);
        }

        private static void RotateMatrix90(List<List<char>> matrix, List<List<char>> result)
        {
            char[,] res = new char[matrix[0].Count, matrix.Count];
            for (int i = 0; i < matrix[0].Count; i++)
            {
                result.Add(new List<char>());
                for (int j = matrix.Count -1; j >= 0; j--)
                {
                    result[i].Add(matrix[j][i]);
                    res[i, matrix.Count - j -1] = matrix[j][i];
                }               
            }
            for (int i = 0; i < res.GetLength(0); i++)
            {
                for (int j = 0; j < res.GetLength(1); j++)
                {
                    Console.Write(res[i,j]);
                }
                Console.WriteLine();
            }
        }

        private static void FillSpaces(int length, List<List<char>> matrix)
        {
            for (int i = 0; i < matrix.Count; i++)
            {
                for (int j = matrix[i].Count; j < length; j++)
                {
                    matrix[i].Add(' ');
                }
            }
        }
    }
}
