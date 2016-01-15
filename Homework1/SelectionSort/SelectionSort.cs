using System;
using System.Collections.Generic;
using System.Linq;

class SelectionSort
{
    static void Main()
    {
        int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        SelectSort(array);

        Console.WriteLine(string.Join(", ",array));
    }

    private static void SelectSort(IList<int> array)
    {        
        for (int i = 0; i < array.Count; i++)
        {
            var min = array[i];
            var index = i;            

            for (int j = i + 1; j < array.Count; j++)
            {
                if (array[j] >= min)
                {
                    continue;
                }
                min = array[j];
                index = j;
            }

            var temp = array[i];
            array[i] = array[index];
            array[index] = temp;
        }
    }
}

