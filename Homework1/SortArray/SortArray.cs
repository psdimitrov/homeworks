using System;
using System.Linq;


class SortArray
{
    static void Main()
    {
        int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        Array.Sort(array);

        Console.WriteLine(string.Join(", ",array));
    }
}
