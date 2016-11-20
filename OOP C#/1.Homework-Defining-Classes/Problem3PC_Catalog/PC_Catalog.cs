using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3PC_Catalog
{
    class PC_Catalog
    {
        static void Main(string[] args)
        {
            Component processor = new Component("Intel Core i7-3632QM", "4-Core, 2.20 GHz", 345);
            Component hdd = new Component("Seagate", 250.45m);
            Computer comp = new Computer("Asus", processor, hdd);
            
            Console.WriteLine(comp);
        }
    }
}
