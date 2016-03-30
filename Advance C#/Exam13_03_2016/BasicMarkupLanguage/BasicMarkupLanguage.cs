using System;
using System.Linq;
using System.Text.RegularExpressions;

public class BasicMarkupLanguage
{
    public static void Main()
    {
        var patern =
            @"\s*<\s*([a-z]+)\s+(?:value\s*=\s*""\s*(\d+)\s*""\s*)?(?:[a-z]+\s*=\s*""([^""]*)"")?\s*\/>\s*";
        Regex rgx = new Regex(patern);
        var input = Console.ReadLine();
        var match = rgx.Match(input);
        int lineNumber = 1;
        while (input != "<stop/>")
        {
            var tag = match.Groups[1].Value;
            switch (tag)
            {
                case "inverse":
                    Inverse(ref lineNumber, match.Groups[3].Value);
                    break;
                case "reverse":
                    Reverse(ref lineNumber, match.Groups[3].Value);
                    break;
                case "repeat":
                    Repeat(ref lineNumber, int.Parse(match.Groups[2].Value), match.Groups[3].Value);
                    break;                        
            }

            input = Console.ReadLine();
            match = rgx.Match(input);
        }
    }

    private static void Repeat(ref int lineNumber, int value, string content)
    {
        if (content.Length > 0)
        {
            for (int i = 0; i < value; i++)
            {
                Console.WriteLine(($"{lineNumber}. {content}"));
                lineNumber++;
            }
        }
    }

    private static void Inverse(ref int lineNumber, string content)
    {
        if (content.Length > 0)
        {
            var invertedContent =
                content.Select(ch => char.IsLower(ch) ? char.ToUpper(ch) : char.IsUpper(ch) ? char.ToLower(ch) : ch);
            Console.WriteLine($"{lineNumber}. {new string(invertedContent.ToArray())}");
            lineNumber++;
        }
    }

    private static void Reverse(ref int lineNumber, string content)
    {
        if (content.Length > 0)
        {
            Console.WriteLine($"{lineNumber}. {new string(content.Reverse().ToArray())}");
            lineNumber++;
        }
    }
}
