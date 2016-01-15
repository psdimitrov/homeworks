using System;
using System.Collections.Generic;
using System.Linq;

class PitagorianNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] numbers = new int[n];
        List<int> squares = new List<int>();
        bool noPitagorian = true;
        for (int i = 0; i < n; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
            squares.Add(numbers[i] * numbers[i]);
        }
       
        foreach (var a in numbers)
        {
            foreach (var b in numbers)
            {
                if (a <= b && squares.Contains(a * a + b * b))
                {
                    var c = Math.Sqrt((a * a + b * b));
                    Console.WriteLine("{0}*{0} + {1}*{1} = {2}*{2}", a, b, c);
                    noPitagorian = false;
                }
            }
        }

        if (noPitagorian)
        {
            Console.WriteLine("No");
        }
    }
}

