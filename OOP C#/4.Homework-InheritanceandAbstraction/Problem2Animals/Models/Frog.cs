using System;

namespace Problem2Animals.Models
{
    class Frog : Animal
    {
        public Frog(string name, int age, string gender) : base(name, age, gender)
        {
        }

        public override void ProduceSound()
        {
            Console.WriteLine("Qwak");
        }

        public override string ToString()
        {                       
            return string.Format("{0} Age: {1} - {2}", this.Name, this.Age, this.Gender);
        }
    }
}
