using System;
using System.Linq;

class ReverseNumber
{
    static void Main()
    {
        double number = double.Parse(Console.ReadLine());

        double reversedNumber = GetReversedNumber(number);
        Console.WriteLine(reversedNumber);
    }

    static double GetReversedNumber(double number)
    {
        string numberAsString = number.ToString();
        string reversed = string.Join("", numberAsString.Reverse().ToArray());
        double reversedNumber = double.Parse(reversed);

        return reversedNumber;
        
    }
}

