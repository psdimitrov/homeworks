using System;


class NumberCalculations
{
    static void Main()
    {
        int[] numbers = { 1, 2, 3, 4 };
        double[] floatingNumbers = { 2.4, 3.5, 2.9, 10.5 };
        decimal[] decNumbers = { 20.32M, 1.0000000004M, 9M };
        FindMinMaxAvg(numbers);
        FindMinMaxAvg(floatingNumbers);
        FindMinMaxAvg(decNumbers);

    }
    static void FindMinMaxAvg(double[] numbers)
    {
        double min = numbers[0];
        double max = numbers[0];
        double sum = 0;
        double product = 1;
        double avg;
        for (int i = 0; i < numbers.Length; i++)
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
            product *= numbers[i];
        }
        avg = sum / numbers.Length;
        Console.WriteLine("Min: {0}, Max: {1}, Average: {2:0.0000}, Sum: {3}, Product {4} \n", min, max, avg, sum, product);
    }
    static void FindMinMaxAvg(int[] numbers)
    {
        int min = numbers[0];
        int max = numbers[0];
        int sum = 0;
        int product = 1;
        double avg;
        for (int i = 0; i < numbers.Length; i++)
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
            product *= numbers[i];
        }
        avg = (double)sum / numbers.Length;
        Console.WriteLine("Min: {0}, Max: {1}, Average: {2:0.0000}, Sum: {3}, Product {4} \n", min, max, avg, sum, product);
    }
    static void FindMinMaxAvg(decimal[] numbers)
    {
        decimal min = numbers[0];
        decimal max = numbers[0];
        decimal sum = 0;
        decimal product = 1;
        decimal avg;
        for (int i = 0; i < numbers.Length; i++)
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
            product *= numbers[i];
        }
        avg = sum / numbers.Length;
        Console.WriteLine("Min: {0}, Max: {1}, Average: {2:0.0000}, Sum: {3}, Product {4} \n", min, max, avg, sum, product);
    }
}

