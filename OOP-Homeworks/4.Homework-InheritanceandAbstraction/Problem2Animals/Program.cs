using Problem2Animals.Models;
using System;
using System.Linq;

namespace Problem2Animals
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal[] animals = new Animal[10]
            {   new Cat("Kornelia", 6, "female"),
                new Kitten("Maca", 1),
                new Tomcat("Tigarcho", 1),
                new Frog("Jabcho", 3, "male"),
                new Dog("Balkan", 3, "male"),
                new Dog("Tara", 4, "female"),
                new Cat("Ita", 3, "female"),
                new Frog("Nansi", 4, "female"),
                new Tomcat("Fiut", 1),
                new Kitten("Pipi", 2) };

            animals.ToList().ForEach(Console.WriteLine);
            Console.WriteLine();

            animals
                .GroupBy(animal => animal.GetType().Name)
                .Select(group => new
                {
                    AnimalName = group.Key,
                    AverageAge = group.Average(a => a.Age)
                })
                .OrderByDescending(group => group.AverageAge)
                .ToList()
                .ForEach(group => Console.WriteLine("{0}'s average age is: {1}", group.AnimalName, group.AverageAge));
        }
    }
}
