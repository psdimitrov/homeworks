using System;
namespace Problem2Animals.Models
{
    class Dog : Animal
    {
        public Dog(string name, int age, string gender) : base(name, age, gender)
        {
        }

        public override void ProduceSound()
        {
            Console.WriteLine("Bauuuu");
        }

        public override string ToString()
        {            
            return string.Format("{0} Age: {1} - {2}", this.Name, this.Age, this.Gender);
        }
    }
}
