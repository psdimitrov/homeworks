using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3PC_Catalog
{
    class Computer
    {
        private string name;
        private List<Component> components = new List<Component>();

        public Computer(string name, params Component[] component)
        {
            this.Name = name;
            
            foreach (var item in component)
            {
                this.components.Add(item);
                
            };
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

        public decimal Price
        {
            get { return this.components.Sum(a => a.Price); }                       
        }

        

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(string.Format("Computer name: {0}\n", this.Name));
            int i = 1;
            foreach (var item in components)
            {
                sb.AppendLine(string.Format("\nComponent {0}:", i));
                sb.AppendLine(item.ToString());
                i++;
            }
            sb.AppendLine("\nTotal price: " + this.Price);

            return sb.ToString();
        }
    }
}
