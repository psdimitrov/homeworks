using System;
using System.Collections.Generic;
using System.Linq;

class LegoBlocks
{
    static void Main(string[] args)
    {
        bool fit = true;
        int sum = 0;
        int n = int.Parse(Console.ReadLine());
        int[][] firstJaggedArray = new int[n][];
        for (int i = 0; i < firstJaggedArray.GetLength(0); i++)
        {
            firstJaggedArray[i] = Console.ReadLine().Trim().Split(new char[] { ' ' },StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
        }
        int[][] secondJaggedArray = new int[n][];
        for (int i = 0; i < secondJaggedArray.GetLength(0); i++)
        {
            secondJaggedArray[i] = Console.ReadLine().Trim().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
        }

        for (int i = 0; i < n-1; i++)
        {
            if(firstJaggedArray[i].Length + secondJaggedArray[i].Length != firstJaggedArray[i+1].Length+secondJaggedArray[i+1].Length)
            {
                fit = false;
            }
            sum += firstJaggedArray[i].Length + secondJaggedArray[i].Length;
        }
        sum += firstJaggedArray[n-1].Length + secondJaggedArray[n-1].Length;

        if (fit)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("[{0}, {1}]", string.Join(", ", firstJaggedArray[i].Select(p => p.ToString())), string.Join(", ", secondJaggedArray[i].Select(p => p.ToString()).Reverse()));
            }
        }
        else
        {
            Console.WriteLine("The total number of cells is: " + sum);
        }

    }
}

