using System;
using System.Collections.Generic;
using System.Linq;

class LongestIncreasing
{
    static void Main(string[] args)
    {
        int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int indexFirstItemIncreasing = 0;
        int length = 1;
        int maxlength = 1;
        bool sequence = false;

        Console.Write(arr[0]);
        for (int i = 1; i < arr.Length; i++)
        {
            if (sequence == true)
            {
                if (arr[i] > arr[i - 1])
                {
                    length++;
                    Console.Write(" " + arr[i]);
                }
                else
                {
                    sequence = false;
                    Console.Write("\n" + arr[i]);
                    if (length > maxlength)
                    {
                        maxlength = length;
                        indexFirstItemIncreasing = i - length;
                    }
                    length = 1;
                }
            }
            else
            {
                if (arr[i] > arr[i - 1])
                {
                    Console.Write(" " + arr[i]);
                    length++;
                    sequence = true;
                }
                else
                {
                    Console.Write("\n" + arr[i]);
                }
            }
        }
        if (length > maxlength)
        {
            maxlength = length;
            indexFirstItemIncreasing = arr.Length -length;
        }
        Console.WriteLine("\nLongest: {0}", string.Join(" ",arr.Select(i => i.ToString()).ToArray(),indexFirstItemIncreasing,maxlength));
    }
}

