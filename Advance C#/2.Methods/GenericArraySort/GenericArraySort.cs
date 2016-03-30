using System;
using System.Collections.Generic;
using System.Linq;

class GenericArraySort
{
    static void Main()
    {


        string[] strings = { "zaz", "cba", "baa", "azis" };
        int[] numbers = { 1, 3, 4, 5, 1, 0, 2 };
        DateTime[] dates = 
        {
            new DateTime( 2014, 09, 04 ),
            new DateTime( 1991, 03, 07 ),
            new DateTime( 1999, 05, 06 )
        };
        
        SortArray(ref strings);        
        SortArray(ref numbers);
        SortArray(ref dates);
        Console.WriteLine("[{0}]", string.Join(", ", strings));
        Console.WriteLine("[{0}]", string.Join(", ", numbers));
        Console.WriteLine("[{0}]", string.Join(", ", dates));
    }
    static void SortArray<T>(ref T[] array) where T : System.IComparable<T>
    {
        bool swap;
        do
        {
            swap = false;
            T temp;     
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i].CompareTo(array[i+1]) > 0)
                {
                    temp = array[i];
                    array[i] = array[i + 1];
                    array[i + 1] = temp;
                    swap = true;
                }
            }
        }
        while (swap == true);
    }
}

