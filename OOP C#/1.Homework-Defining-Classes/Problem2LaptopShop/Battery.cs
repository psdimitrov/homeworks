using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2LaptopShop
{
    class Battery
    {
        private string type;
        private int cells;
        private int milliAh;

        public Battery(string type, int cells, int mAh)
        {
            this.Type = type;
            this.Cells = cells;
            this.MilliAh = mAh;
        }
        
        public string Type
        {
            get { return this.type; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Invalid argument: Type can not be empty value");
                }
                this.type = value;
            }
        }

        public int Cells
        {
            get { return this.cells; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Invalid argument: Cells can not be zero or negative number");
                }
                this.cells = value;
            }
        }
        
        public int MilliAh
        {
            get { return this.milliAh; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Invalid argument: mAh can not be zero or negative number");
                }
                this.milliAh = value;
            }
        }

        public override string ToString()
        {
            return string.Format("{0}, {1}-cells, {2} mAh", this.Type, this.Cells, this.MilliAh);
        }
    }
}
