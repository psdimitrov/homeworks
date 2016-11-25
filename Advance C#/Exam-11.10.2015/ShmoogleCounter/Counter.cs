namespace ShmoogleCounter
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    class Counter
    {
        static void Main(string[] args)
        {
            Regex rgxDouble = new Regex(@"(?<=[^\w])double\s+(?<var>[a-z_]\w*)");
            Regex rgxInt = new Regex(@"(?<=[^\w])int\s+(?<var>[a-z_]\w*)");
            string input = Console.ReadLine();
            List<string> doubleVariables = new List<string>();
            List<string> intVariables = new List<string>();
            while (input != "//END_OF_CODE")
            {
                MatchCollection doubleMatches = rgxDouble.Matches(input);
                doubleVariables.AddRange(from Match match in doubleMatches select match.Groups["var"].Value);

                MatchCollection intMatches = rgxInt.Matches(input);
                intVariables.AddRange(from Match match in intMatches select match.Groups["var"].Value);
                input = Console.ReadLine();

            }

            if (doubleVariables.Count == 0)
            {
                Console.WriteLine("Doubles: None");
            }
            else
            {
                doubleVariables.Sort();
                Console.WriteLine("Doubles: {0}", string.Join(", ", doubleVariables));
            }

            if (intVariables.Count == 0)
            {
                Console.WriteLine("Ints: None");
            }
            else
            {
                intVariables.Sort();
                Console.WriteLine("Ints: {0}", string.Join(", ", intVariables));
            }
        }
    }
}
