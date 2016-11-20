using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2LaptopShop
{
    class LaptopShop
    {
        static void Main(string[] args)
        {
            Battery battery = new Battery("Li-Ion", 4, 2550);
            Laptop laptop = new Laptop(
                "Lenovo Yoga 2 Pro", "Lenovo",
                "Intel Core i5-4210U (2-core, 1.70 - 2.70 GHz, 3MB cache)",
                8,
                "Intel HD Graphics 4400", 
                "128GB SSD",
                "13.3\" (33.78 cm) – 3200 x 1800 (QHD+), IPS sensor display",
                battery, 
                4.5,
                2259);
            Laptop asus = new Laptop("Asus", 1599.99m);
            Console.WriteLine(laptop);
            Console.WriteLine(asus);
        }
    }
}
