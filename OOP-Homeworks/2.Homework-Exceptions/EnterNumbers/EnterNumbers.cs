using System;

namespace EnterNumbers
{
    class EnterNumbers
    {
        static void Main(string[] args)
        {
            int num = 1;

            for (int i = 0; i < 10; i++)
            {
                try
                {
                    num = ReadNumber(num + 1, 100);
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine("You entered invalid number. The number should be bigger than the last number entered({0}) and less than 100\nPlease enter again:", num);
                    i--;
                }
                catch (FormatException)
                {
                    Console.WriteLine("You entered invalid number.\nPlease enter again:");
                    i--;
                }
            }
        }

        static int ReadNumber(int start, int end)
        {
            int number = int.Parse(Console.ReadLine());
            if (number < start || number >= end)
            {
                throw new ArgumentOutOfRangeException();
            }

            return number;
        }
    }
}
