using System;

namespace Square_root
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int num = int.Parse(Console.ReadLine());
                if (num < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                Console.WriteLine("Square root is: " + Math.Sqrt(num));
            }
            catch(ArgumentOutOfRangeException)
            {
                Console.WriteLine("Invalid number!");
            }
            catch(OverflowException)
            {
                Console.WriteLine("Invalid number!");
            }
            catch(FormatException)
            {
                Console.WriteLine("Invalid number!");
            }
            finally
            {
                Console.WriteLine("Good bye!");
            }

        }
    }
}
