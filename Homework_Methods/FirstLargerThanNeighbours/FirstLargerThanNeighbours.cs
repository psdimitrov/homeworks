using System;

class FirstLargerThanNeighbours
{
    static void Main()
    {
        int[] numbers = { 1, 1, 1, 2, 3, 4, 4 };

        Console.WriteLine(GetIndexOfFirstLargerThanNeighbours(numbers));
    }
    static int GetIndexOfFirstLargerThanNeighbours(int[] numbers)
    {
        if (numbers[0] > numbers[1])
        {
            return 0;
        }
        else
        {
            for (int i = 1; i < numbers.Length - 1; i++)
            {
                if (numbers[i] > numbers[i - 1] && numbers[i] > numbers[i + 1])
                {
                    return i;
                }
            }
            if (numbers[numbers.Length - 1] > numbers[numbers.Length - 2])
            {
                return numbers.Length - 1;
            }
            else
            {
                return -1;
            }
        }
    }
}

