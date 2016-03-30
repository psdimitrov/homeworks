using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ExtractHypelinks
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(?:<a[^>]*)href *=\s*(""(?<url>[^"">]*)""|'(?<url>[^'>]*)'|(?<url>[^""' >]*))[^>]*>";
            Regex rgx = new Regex(pattern);
            StringBuilder sb = new StringBuilder();
            List<string> output = new List<string>();
            string input = Console.ReadLine();
            while (input!="END")
            {
                sb.Append(input);
                input = Console.ReadLine();
            }
            string text = sb.ToString();
            
            MatchCollection matches = rgx.Matches(text);
            foreach (Match match in matches)
            {
                Console.WriteLine(match.Groups["url"].Value);               
            }
            
            
        
        }
    }
}
