using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3PC_Catalog
{
    class Component
    {
        private string name;
        private string details;
        private decimal price;

        public Component(string name, string details, decimal price)
        {
            this.Name = name;
            this.Details = details;
            this.Price = price;
        }

        public Component(string name, decimal price) : this(name, null, price)
        {
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

        public string Details
        {
            get { return this.details; }
            set
            {
                if (value != null && value.Trim().Length == 0)
                {
                    throw new ArgumentException("Invalid argument: Details sould not be empty.");
                }
                this.details = value;
            }
        }

        public decimal Price
        {
            get { return this.price; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Invalid argument: Price sould not be negative.");
                }
                this.price = value;
            }
        }

        public override string ToString()
        {

            return string.Format("Component name: " + this.Name + (this.Details != null ? ("\nDetails: " + this.Details) : "") + "\nPrice: " + this.Price);
        }
    }
}
