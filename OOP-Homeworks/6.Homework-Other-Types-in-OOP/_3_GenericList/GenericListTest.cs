using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_GenericList
{
    class GenericListTest
    {
        static void Main(string[] args)
        {
            GenericList<int> list = new GenericList<int>();
            list.Add(1);
            list.Add(2);
            list.Add(7);
            Console.WriteLine(list);
            list.Add(5);
            list.Add(6);                                    
            list.Insert(2, 3);
            list[3] = 4;
            Console.WriteLine(list);
            list.RemoveAt(5);
            
            Console.WriteLine(list.Max());            
            Console.WriteLine(list);            
        }
    }
}
