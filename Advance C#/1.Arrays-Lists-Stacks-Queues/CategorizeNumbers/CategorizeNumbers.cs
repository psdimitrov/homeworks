using System;
using System.Collections.Generic;
using System.Linq;

class CategorizeNumbers
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(' ');
        List<double> roundNumbers = new List<double>();
        List<double> nonRoundNumbers = new List<double>();
        double value = 0;

        for (int i = 0; i < input.Length; i++)
        {
            value = double.Parse(input[i]);
            if (value % 1 < double.Epsilon)
            {
                roundNumbers.Add(value);
            }
            else
            {
                nonRoundNumbers.Add(value);
            }
        }
        if (nonRoundNumbers.Count > 0)
        {
            Console.Write("[{0}]", string.Join(", ",nonRoundNumbers));
            FindMinMaxAvg(nonRoundNumbers);
        }
        if (roundNumbers.Count > 0)
        {
            Console.Write("[{0}]",string.Join(", ",roundNumbers));
            FindMinMaxAvg(roundNumbers);
        }
    }
    static void FindMinMaxAvg(List<double> numbers)
    {
        double min = numbers[0];
        double max = numbers[0];
        double sum = 0;
        double avg;
        for (int i = 0; i < numbers.Count; i++)
        {
            if (numbers[i] < min)
            {
                min = numbers[i];
            }
            else if (numbers[i] > max)
            {
                max = numbers[i];
            }
            sum += numbers[i];
        }
        avg = sum / numbers.Count;
        Console.Write(" -> min: {0}, max: {1}, sum: {2}, avg: {3:0.00} \n", min, max, sum, avg);
        Console.WriteLine();
    }
}
