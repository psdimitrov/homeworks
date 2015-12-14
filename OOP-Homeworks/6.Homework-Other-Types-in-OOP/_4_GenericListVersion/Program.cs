using System;
using _3_GenericList;

namespace _4_GenericListVersion
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericList<int> list = new GenericList<int>();
            Console.WriteLine(list.Version());
        }
    }
}
