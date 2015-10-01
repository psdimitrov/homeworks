using System;
using System.Collections.Generic;
using System.Linq;

class CountSymbols
{
    static void Main()
    {
        string input = Console.ReadLine();
        Dictionary<char, int> symbols = new Dictionary<char, int>();
        for (int i = 0; i < input.Length; i++)
        {
            if (symbols.ContainsKey(input[i]))
            {
                symbols[input[i]]++;
            }
            else
            {
                symbols.Add(input[i], 1);
            }
        }
        var list = symbols.Keys.ToList();
        list.Sort();
        foreach (var item in list)
        {
            Console.WriteLine(item + ": " + symbols[item] + " time/s");
        }
        
    }
}
