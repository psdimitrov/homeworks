using System;


namespace Problem2Animals.Models
{
    class Tomcat : Cat
    {
        private const string Gender = "male";

        public Tomcat(string name, int age) : base(name, age, Gender)
        {
        }

        public override void ProduceSound()
        {
            Console.WriteLine("Tomcat said: Miay");
        }

        public override string ToString()
        {                        
            return string.Format("{0} Age: {1} - {2}", this.Name, this.Age, Gender);
        }
    }
}
