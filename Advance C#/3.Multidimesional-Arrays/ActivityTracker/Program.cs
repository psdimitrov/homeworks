using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActivityTracker
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Dictionary<string, decimal>> footsteps = new List<Dictionary<string, decimal>>();
            SortedSet<int> dates = new SortedSet<int>();
            for (int i = 0; i < 12; i++)
            {
                footsteps.Add(new Dictionary<string,decimal>());
            }
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                int date = int.Parse(input.Substring(3, 2)) - 1;
                string[] tokens = input.Split(' ');
                string name = tokens[1];
                decimal distance = decimal.Parse(tokens[2]);
                
                if(!footsteps[date].ContainsKey(name))
                {
                    footsteps[date].Add(name, distance);
                    dates.Add(date);
                }
                else
                {
                    footsteps[date][name] += distance;
                }
            }
            foreach (var i in dates)
            {                                                                   
                    var ordered = footsteps[i].OrderBy(x => x.Key).ToDictionary(x=> x.Key,y => y.Value);
                    Console.Write("{0}: ", i + 1);
                    List<string> temp = new List<string>();
                    foreach (var item in ordered)
                    {
                        temp.Add(string.Format("{0}({1})", item.Key, item.Value));
                    }
                    Console.WriteLine( string.Join(", ",temp));                                        
            }
            
        }
    }
}
