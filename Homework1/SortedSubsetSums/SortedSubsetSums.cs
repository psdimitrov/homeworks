using System;
using System.Collections.Generic;
using System.Linq;

class SubsetSum
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).Distinct().ToArray();

        List < List <int> > subsets= new List<List<int>>();
        double combinations = Math.Pow(2, numbers.Length);

        bool noSum = true;
        subsets.Add(new List<int>());
        int k = 0;
        for (int i = 1; i < combinations; i++)
        {
            int sum = 0;
            for (int j = 0; j < numbers.Length; j++)
            {
                int mask = i & (1 << j);
                if (mask != 0)
                {
                    sum += numbers[j];
                    subsets[k].Add(numbers[j]);
                }
            }

            if (sum == n)
            {
                subsets[k].Sort();
                subsets.Add(new List<int>());
                k++;
                noSum = false;
            }
            else
            {
                subsets[k].Clear();
            }
        }
        subsets.RemoveAt(k);
        if (noSum)
        {
            Console.WriteLine("No matching subsets.");
        }
        else
        {
            subsets = subsets.OrderBy(i => i[0]).ToList();
            subsets = subsets.OrderBy(i => i.Count).ToList();
            foreach (var item in subsets)
            {
                Console.WriteLine(string.Join(" + ", item) + " = " + n);
            }
        }
    }
}
