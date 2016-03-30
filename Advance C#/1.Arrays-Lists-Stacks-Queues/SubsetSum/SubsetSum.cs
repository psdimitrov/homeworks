using System;
using System.Collections.Generic;
using System.Linq;

class SubsetSum
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).Distinct().ToArray();

        List<int> subset = new List<int>();
        double combinations = Math.Pow(2, numbers.Length);

        bool noSum = true;

        for (int i = 1; i < combinations; i++)
        {
            int sum = 0;
            for (int j = 0; j < numbers.Length; j++)
            {
                int mask = i & (1 << j);
                if (mask != 0)
                {
                    sum += numbers[j];
                    subset.Add(numbers[j]);
                }
            }

            if (sum == n)
            {
                Console.WriteLine(string.Join(" + ", subset) + " = " + sum);
                noSum = false;
            }

            subset.Clear();
        }

        if (noSum)
        {
            Console.WriteLine("No matching subsets.");
        }
    }
}
