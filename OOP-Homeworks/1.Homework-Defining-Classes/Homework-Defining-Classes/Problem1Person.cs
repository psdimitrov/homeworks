using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Defining_Classes
{
    class Problem1Person
    {
        static void Main(string[] args)
        {
            Person pesho = new Person("Pesho", 24);
            Console.WriteLine(pesho.ToString());
        }
    }
}
