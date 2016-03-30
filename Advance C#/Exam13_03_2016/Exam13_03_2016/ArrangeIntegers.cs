using System;
using System.Linq;

public class Program
{
    private static readonly string[] Numbers = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
    public static void Main()
    {
        Console.WriteLine(string.Join(", ", Console.ReadLine()
            .Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
            .OrderBy(str => string.Join("", str.Select(ch => Numbers[ch - '0'])))));
    }
}

