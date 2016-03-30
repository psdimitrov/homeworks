using System;
using System.Text.RegularExpressions;


namespace ValidUsernames
{
    class ValidUsernames
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"(?<=\s|^|\/|\\|\(|\))([a-zA-Z]\w{2,24})(?=\s|\\|\/|\(|\)|$)";
            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(input);
            int sum = 0;
            int biggestSum = 0;
            int index = 0;

            for (int i = 0; i < matches.Count-1; i++)
            {
                sum = matches[i].Length + matches[i + 1].Length;
                if (sum > biggestSum)
                {
                    biggestSum = sum;
                    index = i;
                }
            }
            Console.WriteLine(matches[index]);
            Console.WriteLine(matches[index + 1]);
        }
    }
}
