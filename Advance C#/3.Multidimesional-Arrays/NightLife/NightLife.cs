using System;
using System.Collections.Generic;


class NightLife
{
    static void Main(string[] args)
    {
        Dictionary<string, SortedDictionary<string, SortedSet<string>>> nightGuide = new Dictionary<string, SortedDictionary<string, SortedSet<string>>>();
        string input = Console.ReadLine();
        string[] data;
        string city = string.Empty;
        string venue = string.Empty;
        string performer = string.Empty;

        while(input!="END")
        {
            data = input.Split(';');
            city = data[0];
            venue = data[1];
            performer = data[2];            

            if(!nightGuide.ContainsKey(city))
            {
                nightGuide[city] = new SortedDictionary<string, SortedSet<string>>();
            }
            if(!nightGuide[city].ContainsKey(venue))
            {
                nightGuide[city][venue] = new SortedSet<string>();
            }
            nightGuide[city][venue].Add(performer);
            input = Console.ReadLine();
        }

        foreach (var item in nightGuide)
        {
            Console.WriteLine(item.Key);
            foreach (var elem in item.Value)
            {
                Console.WriteLine("->{0}: {1}",elem.Key,string.Join(", ",elem.Value));
            }
        }
    }
}
