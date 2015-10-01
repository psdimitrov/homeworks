using System;
using System.Linq;

class ReverseString
{
    static void Main()
    {
        string str = Console.ReadLine();
        char[] arr = str.Reverse().ToArray() ;
        Console.WriteLine(arr);
    }
}

