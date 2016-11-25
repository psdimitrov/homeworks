namespace ArrayManipulator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class ArrayManipulator
    {
        static void Main(string[] args)
        {
            List<int> array = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            string input = Console.ReadLine();
            while (input != "end")
            {
                string[] commands = input.Split(' ');

                switch (commands[0])
                {
                    case "exchange":
                        Exchange(array, commands[1]);
                        break;
                    case "max":
                        Max(array, commands[1]);
                        break;
                    case "min":
                        Min(array, commands[1]);
                        break;
                    case "first":
                        First(array, commands[1], commands[2]);
                        break;
                    case "last":
                        Last(array, commands[1], commands[2]);
                        break;                    
                }

                input = Console.ReadLine();                
            }

            Console.WriteLine("[{0}]", string.Join(", ",array));
        }

        private static void First(List<int> array, string p1, string p2)
        {
            
            int count = int.Parse(p1);                            
            if (count > array.Count)
            {
                Console.WriteLine("Invalid count");
            }
            else
            {
                List<int> temp = new List<int>();
                if (p2 == "odd")
                {
                    temp = array.Where(x => x % 2 == 1).ToList();
                    if (count < temp.Count)
                    {
                        temp.RemoveRange(count, temp.Count - count);
                    }

                    Console.WriteLine("[{0}]", string.Join(", ", temp));
                }
                else
                {
                    temp = array.Where(x => x % 2 == 0).ToList();
                    if (count < temp.Count)
                    {
                        temp.RemoveRange(count, temp.Count - count);
                    }

                    Console.WriteLine("[{0}]", string.Join(", ", temp));
                }
            }
        }
        private static void Last(List<int> array, string p1, string p2)
        {

            int count = int.Parse(p1);
            if (count > array.Count)
            {
                Console.WriteLine("Invalid count");
            }
            else
            {
                List<int> temp = new List<int>();
                if (p2 == "odd")
                {
                    temp = array.Where(x => x % 2 == 1).ToList();
                    if (count < temp.Count)
                    {
                        temp.RemoveRange(0, temp.Count - count);
                    }
                    Console.WriteLine("[{0}]", string.Join(", ", temp));
                }
                else
                {
                    temp = array.Where(x => x % 2 == 0).ToList();
                    if (count < temp.Count)
                    {
                        temp.RemoveRange(0, temp.Count - count);
                    }
                    Console.WriteLine("[{0}]", string.Join(", ", temp));
                }
            }
        }

        private static void Max(List<int> array, string p)
        {
            try
            {
                switch (p)
                {
                    case "odd":
                        {
                            var max = (array.Where(x => x % 2 == 1).Max());
                            Console.WriteLine(array.LastIndexOf(max));
                        }                
                        break;
                    case "even":
                        {
                            var max = (array.Where(x => x % 2 == 0).Max());
                            Console.WriteLine(array.LastIndexOf(max));
                        }
                        break;
                }
            }
            catch (InvalidOperationException)
            {
                Console.WriteLine("No matches");
            }
        }
        private static void Min(List<int> array, string p)
        {
            try
            {                
                switch (p)
                {
                    case "odd":
                        {                    
                            var min = (array.Where(x => x % 2 == 1).Min());
                            Console.WriteLine(array.LastIndexOf(min));
                        }
                        break;
                    case "even":
                        {
                            var min = (array.Where(x => x % 2 == 0).Min());
                            Console.WriteLine(array.LastIndexOf(min));
                        }
                        break;
                }                
            }
            catch (InvalidOperationException)
            {
                Console.WriteLine("No matches");
            }
        }

        private static void Exchange(List<int> array, string indexStr)
        {
            int index = int.Parse(indexStr);
            if (index < 0 || index >= array.Count)
            {
                Console.WriteLine("Invalid index");
            }
            else
            {
                var elements = array.Take(index + 1).ToArray();
                array.AddRange(elements);
                array.RemoveRange(0, index + 1);
            }
        }
    }
}
