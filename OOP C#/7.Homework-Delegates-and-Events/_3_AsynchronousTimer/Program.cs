using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_AsynchronousTimer
{
    class Program
    {
        static void Main(string[] args)
        {
            var timer = new AsyncTimer(Console.WriteLine, 10, 3);
            timer.Run();
        }
    }
}
