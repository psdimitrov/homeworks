using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Defining_Classes
{
    class Person
    {
        private string name;
        private int age;
        private string email;

        public Person(string name, int age) : this(name, age, null)
        {                
        }
        public Person(string name, int age, string email)
        {
            this.Name = name;
            this.Age = age;
            this.Email = email;
        }

        public string Name
        {
            get 
            {
                return this.name;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Invalid argument: Name should not be empty.");                   
                }
                this.name = value;               
            }
        }

        public int Age
        {
            get { return this.age; }
            set
            {
                if (value <= 0 || value > 100)
                {
                    throw new ArgumentOutOfRangeException("Invalid argument: Age should be between 1 and 100.");
                }
                this.age = value;
            }
        }

        public string Email
        {
            get { return this.email; }
            set
            {
                if (value == null || value.Length > 0 && value.Contains("@"))
                {
                    this.email = value;
                }
                else
                {
                    throw new ArgumentException("Invalid argument: Email should contains the symbol @");
                }
            }
        }
        public override string ToString()
        {
            return string.Format("Person name: {0} \nAge: {1}\n" + (this.email == null ? "" : "Email: {2}"), this.name, this.age, this.email);
        }
    }
}
