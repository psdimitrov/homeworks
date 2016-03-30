using System;
using System.Text.RegularExpressions;

class ReplaceAtag
{
    static void Main()
    {
        string text = Console.ReadLine();
        string pattern = @"<a(.*href=(""|')((?:.|\n)*?(?=\2)))(\2)>((?:.|\n)*?(?=<))<\/a>";
        string replace = @"[URL href=$3]$5[/URL]";
        Regex regex = new Regex(pattern);
        string replaced = regex.Replace(text, replace);
        Console.WriteLine(replaced);
    }
}