using System;
using System.Text.RegularExpressions;

class SeriesOfLetters
{
    static void Main()
    {
        string pattern = @"([A-Za-z])\1+";
        Regex regex = new Regex(pattern);

        string text = Console.ReadLine();
        text = regex.Replace(text, match => match.Value[0].ToString());
        Console.WriteLine(text);
    }
}