using System;
using System.Linq;

class SelectionSort
{
    static void Main()
    {
        int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        SelectSort(array);

        Console.WriteLine(string.Join(", ",array));
    }

    private static void SelectSort(int[] array)
    {
        int temp;
        int min;
        int index;
        
        for (int i = 0; i < array.Length; i++)
        {
            min = array[i];
            index = i;            

            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[j] < min)
                {
                    min = array[j];
                    index = j;
                }
            }

            temp = array[i];
            array[i] = array[index];
            array[index] = temp;

        }
    }
}

