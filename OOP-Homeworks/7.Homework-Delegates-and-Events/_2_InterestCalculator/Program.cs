using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_InterestCalculator
{
    
    class Program
    {
        private const int N = 12;
        static void Main(string[] args)
        {
                  
            var compound = new InterestCalculator(500, 5.6, 10, GetCompoundInterest);
            Console.WriteLine(compound);

            var simple = new InterestCalculator(2500, 7.2, 15, GetSimpleInterest);
            Console.WriteLine(simple);
        }

        private static double GetSimpleInterest(double sum, double interest, int years)
        {
            return sum * (1 + (interest / 100) * years);
        }

        private static double GetCompoundInterest(double sum, double interest, int years)
        {
            return sum * Math.Pow((1 + (interest / 100) / N), N * years);
        }

    }
}
