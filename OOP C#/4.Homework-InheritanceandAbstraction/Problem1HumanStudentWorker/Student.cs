using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Problem1HumanStudentWorker
{
    class Student : Human
    {
        private string facNumber;

        public Student(string firstName, string lastName, string facNumber)
            : base(firstName, lastName)
        {
            this.FacNumber = facNumber;
        }
        public string FacNumber
        {
            get
            {
                return this.facNumber;
            }
            set
            {
                if (!Regex.IsMatch(value,"^[A-Za-z0-9]{5,10}$"))
                {
                    throw new ArgumentException("Faculty number should be between 5-10 digits/letters");
                }
                this.facNumber = value;
            }
        }

        public override string ToString()
        {
            return base.ToString() + " Faculty number: " + this.FacNumber;
        }
    }
}
