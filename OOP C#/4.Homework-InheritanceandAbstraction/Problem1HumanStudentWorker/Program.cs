using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1HumanStudentWorker
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>() 
            { 
                new Student("Pesho", "Dimitrov", "1234567ls"),
                new Student("Gosho", "Petrov", "4321243fk"),
                new Student("Minka", "Bahova", "4212327ir"),
                new Student("Dimitar", "Stoyanov", "5633411rt"),
                new Student("Stefan", "Petrov", "8439132oe"),
                new Student("Svetoslav", "Nikolov", "9293124eo"),
                new Student("Ivailo", "Ivanov", "5452003pr"),
                new Student("Lubo", "Petrov", "8949221po"),
                new Student("Georgi", "Georgiev", "8535234rt"),
                new Student("Petar", "Kolev", "8534234op")
            };
            List<Worker> workers = new List<Worker>()
            {
                new Worker("Marin", "Kolev", 456.5M, 8),
                new Worker("Nikola", "Asenov", 230M, 5),
                new Worker("Aleksander", "Aleksandrov", 560M, 10),
                new Worker("Stoyan", "Plamenov", 440.5M, 8),
                new Worker("Dimitar", "Panaiotov", 334M, 7),
                new Worker("Petar", "Alexandrov", 90M, 3),
                new Worker("Georgi", "Parishev", 1000M, 8),
                new Worker("Kostadin", "Nikolaev", 78M, 2),
                new Worker("Nikolay", "Dimitrov", 434M, 7),
                new Worker("Dian", "Konstantinov", 556M, 9)
            };

            var orderedStudents = students.OrderBy(a => a.FacNumber);
            foreach (var student in orderedStudents)
            {
                Console.WriteLine(student);                
            }
            Console.WriteLine();
            var orderedWorkers = workers.OrderByDescending(p => p.MoneyPerHour());
            foreach (var worker in orderedWorkers)
            {
                Console.WriteLine(worker);
            }
            Console.WriteLine();
            List<Human> humans = new List<Human>(orderedStudents);
            humans.AddRange(orderedWorkers);
            var orderedHumans = humans.OrderBy(h => h.FirstName).ThenBy(h => h.LastName);

            foreach (var human in orderedHumans)
            {
                Console.WriteLine(human);
            }
        }
    }
}
