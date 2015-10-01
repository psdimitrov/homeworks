using System;
using System.Linq;

class StuckNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string[] numbers = new string[n];
        numbers = Console.ReadLine().Split(' ').ToArray();
        bool noStuckNumbers = true;

        if(n<4)
        {
            Console.WriteLine("No");
        }
        else
        {
            for (int a = 0; a < n; a++)
            {
                for (int b = 0; b < n; b++)
                {
                    for (int c = 0; c < n; c++)
                    {
                        for (int d = 0; d < n; d++)
                        {
                            if(numbers[a]+numbers[b]==numbers[c]+numbers[d] && a!=b && b!=c && c!=d && a!=c && a!=d && b!=d)
                            {
                                noStuckNumbers = false;
                                Console.WriteLine("{0}|{1}=={2}|{3}",numbers[a],numbers[b],numbers[c],numbers[d]);
                            }
                        }
                    }   
                }   
            }
            if (noStuckNumbers)
            {
                Console.WriteLine("No");
            }
        }
    }
}

