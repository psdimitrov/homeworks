using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace QueryMess
{
    class QueryMess
    {
        static void Main(string[] args)
        {
            string patern = @"([^&=?\n]+)=([^&=?\n]+)";
            var rgx = new Regex(patern);            
            string input = Console.ReadLine();
            while (input != "END")
            {
                input = Regex.Replace(input, @"(\+|%20)+", " ");
                MatchCollection matches = rgx.Matches(input);
                Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();
                foreach (Match match in matches)
	            {
		            string field = match.Groups[1].Value.Trim();
                    string value = match.Groups[2].Value.Trim();

                    if (!dict.ContainsKey(field))
                    {
                        dict[field] = new List<string>();                        
                    }
                    dict[field].Add(value);                
	            }
                foreach (var item in dict)
                {
                    Console.Write("{0}=[{1}]", item.Key, string.Join(", ",item.Value));
                }
                Console.WriteLine();
                input = Console.ReadLine();
            }
        }
    }
}
