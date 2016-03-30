using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class StingLength
{
    static void Main()
    {
        string str = Console.ReadLine();
        string newStr = string.Empty;
        if(str.Length>=20)
        {
            newStr = str.Substring(0, 20);
        }
        else
        {
            newStr = str + new string('*', 20 - str.Length);
        }

        Console.WriteLine(newStr);
    }
}

