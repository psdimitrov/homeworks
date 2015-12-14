using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_StudentClass
{
    class Student
    {
        private string name;
        private int age;

        public delegate void PropertyChangedEventHandler(object obj, PropertyChangedEventArgs args);
        public event PropertyChangedEventHandler PropertyChanged;

        public Student(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                this.IsChanged(this.name, value, "Name");
                this.name = value;
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }

            set
            {
                this.IsChanged(this.age, value, "Age");
                this.age = value;
            }
        }

        private void IsChanged(Object oldValue, Object newValue, string title)
        {
            var onPropCh = this.PropertyChanged;
            if (onPropCh != null)
            {
                onPropCh(this, new PropertyChangedEventArgs(oldValue, newValue, title));
            }
        }
    }
}
