using System;

class LargerThanNeighbours
{
    static void Main()
    {
        int[] numbers = { 1, 3, 4, 5, 1, 0, 5 };

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine(IsLargerThanNeighbours(numbers,i));
        }
    }

    static string IsLargerThanNeighbours(int[] numbers, int i)
    {
        if (i > 0 && i < numbers.Length-1)
        {
            if(numbers[i]>numbers[i-1] && numbers[i]>numbers[i+1])
            {
                return "True";
            }
            else
            {
                return "False";
            }
        }
        else if(i==0)
        {
            if(numbers[0]>numbers[1])
            {
                return "True";
            }
            else
            {
                return "False";
            }
        }
        else if (i==numbers.Length-1)
        {
            if(numbers[i] > numbers[i-1])
            {
                return "True";
            }
            else
            {
                return "False";
            }
        }
        else
        {
            return "The position is outside the boundaries of the given array";
        }   
    }
}
