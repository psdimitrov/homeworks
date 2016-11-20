using System;


namespace Problem2Animals.Models
{
    class Kitten : Cat
    {
        private const string Gender = "female";

        public Kitten(string name, int age) : base(name, age, Gender)
        {
        }


        public override string ToString()
        {                        
            return string.Format("{0} Age: {1} - {2}", this.Name, this.Age, Gender);
        }
    }
}
