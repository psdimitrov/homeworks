using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var filteredCollection = list.WhereNot(a => a % 2 == 0);

            Console.WriteLine(string.Join(", ", filteredCollection));

            List<Student> students = new List<Student>
            {
                new Student("Pesho", 3),
                new Student("Gosho", 2),
                new Student("Mariika", 7),
                new Student("Stamat", 5),
            };
            
            Console.WriteLine(students.Max(student => student.Grade));
        }
    }
}
