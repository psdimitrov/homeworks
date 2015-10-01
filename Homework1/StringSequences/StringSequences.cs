using System;
using System.Collections.Generic;
using System.Linq;

class StringSequences
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(' ');
        List<string> result = new List<string>();
        int index = 0;

        if(input.Length>0)
        {
            result.Add(input[0]);
        }
        for (int i = 1; i < input.Length; i++)
        {
            if(input[i]==input[i-1])
            {
                result[index] = result[index] + " " + input[i];
            }
            else
            {
                result.Add(input[i]);
                index++;
            }
        }
        foreach (var item in result)
        {
            Console.WriteLine(item);
        }
    }
}