namespace Srbsko
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    class Srbsko
    {
        static void Main(string[] args)
        {
            var statistic = new Dictionary<string, Dictionary<string, int>>();
            var rgx = new Regex(@"([^@]*) @(\D*) \d");
            var input = Console.ReadLine();
            while (input!="End")
            {
                var tokens = input.Split(' ');
                if (tokens.Length >=4 && tokens.Length <= 8)
                {
                    var match = rgx.Match(input);
                    if (match.Success)
                    {
                        var singer = match.Groups[1].Value;
                        var venue = match.Groups[2].Value;
                        var ticketPrice = int.Parse(tokens[tokens.Length - 2]);
                        var ticketCount = int.Parse(tokens[tokens.Length - 1]);
                        if (!statistic.ContainsKey(venue))
                        {
                            statistic[venue] = new Dictionary<string, int>();
                        }
                        if (!statistic[venue].ContainsKey(singer))
                        {
                            statistic[venue][singer] = ticketCount * ticketPrice;
                        }
                        else
                        {
                            statistic[venue][singer] += (ticketCount * ticketPrice);
                        }
                    }
                }
                
                input = Console.ReadLine();
            }
            
            foreach (var venue in statistic.Keys)
            {
                Console.WriteLine("{0}",venue);
                var sorted = statistic[venue].OrderByDescending(x => x.Value).ToDictionary(a => a.Key, b => b.Value);
                foreach (var singer in sorted)
                {
                    Console.WriteLine("#  {0} -> {1}", singer.Key, singer.Value);
                }
            }
        }
    }
}
