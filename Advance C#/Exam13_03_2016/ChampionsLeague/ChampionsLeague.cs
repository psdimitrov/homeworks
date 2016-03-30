using System;
using System.Collections.Generic;
using System.Linq;

class ChampionsLeague
{
    static void Main()
    {
        SortedDictionary<string, int> wins = new SortedDictionary<string, int>();
        Dictionary<string, SortedSet<string>> opponents = new Dictionary<string, SortedSet<string>>();
        while (true)
        {
            var input = Console.ReadLine();

            if (input == "stop")
            {
                break;
            }

            var tokens = input.Split('|').Select(x => x.Trim()).ToArray();
            var team1 = tokens[0];
            var team2 = tokens[1];
            var result1 = tokens[2].Split(':').Select(int.Parse).ToArray();
            var result2 = tokens[3].Split(':').Select(int.Parse).ToArray();
            var team1goals = result1[0] + result2[1];
            var team2goals = result1[1] + result2[0];
            var winner = string.Empty;
            if (team1goals == team2goals)
            {
                winner = result1[1] > result2[1] ? team2 : team1;
            }
            else if (team1goals > team2goals)
            {
                winner = team1;
            }
            else
            {
                winner = team2;
            }

            if (!wins.ContainsKey(team1))
            {
                wins.Add(team1, 0);
                opponents.Add(team1, new SortedSet<string>());
            }

            opponents[team1].Add(team2);

            if (!wins.ContainsKey(team2))
            {
                wins.Add(team2, 0);
                opponents.Add(team2, new SortedSet<string>());
            }

            opponents[team2].Add(team1);

            wins[winner]++;

        }

        var orderedTeams = wins.OrderByDescending(x => x.Value);

        foreach (var keyValuePair in orderedTeams)
        {
            Console.WriteLine(keyValuePair.Key);
            Console.WriteLine("- Wins: {0}", keyValuePair.Value);
            Console.WriteLine("- Opponents: {0}", string.Join(", ", opponents[keyValuePair.Key]));
        }
    }
}
