using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2LaptopShop
{
    class Laptop
    {
        private string model;
        private string manufacturer;
        private string processor;
        private int ram;
        private string graphicsCard;
        private string hdd;
        private string screen;
        private Battery battery;
        private double batteryLife;
        private decimal price;
        private string p1;
        private double p2;

        public Laptop(
            string model,
            string manufacturer,
            string processor,
            int ram, 
            string graphicsCard,
            string hdd, 
            string screen,
            string batteryType, 
            int baterryCells,
            int baterryMilliAh,
            double batteryLife,
            decimal price )
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Processor = processor;
            this.Ram = ram;
            this.GraphicsCard = graphicsCard;
            this.Hdd = hdd;
            this.Screen = screen;
            this.Battery = new Battery(batteryType, baterryCells, baterryMilliAh);
            this.BatteryLife = batteryLife;
            this.Price = price;
        }

        public Laptop(
            string model,
            string manufacturer,
            string processor,
            int ram, 
            string graphicsCard,
            string hdd, 
            string screen,
            Battery battery,
            double batteryLife,
            decimal price )
        {
            this.Model = model;
            this.Manufacturer = manufacturer;            
            this.Processor = processor;
            this.Ram = ram;
            this.GraphicsCard = graphicsCard;
            this.Hdd = hdd;
            this.Screen = screen;
            this.Battery = battery;
            this.BatteryLife = batteryLife;
            this.Price = price;
        }

        public Laptop(string model, string processor, string screen, Battery battery, decimal price ) 
            : this(model, null, processor, 0, null, null, screen, battery, 0, price)
        {
        }

        public Laptop(string model, decimal price)
            : this(model, null, null, null, price)
        {
            this.Model = model;
            this.Price = price;
        }

        public string Model 
        {
            get { return this.model; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Invalid argument: Model should not be empty.");
                }
                this.model = value;
            }
        }

        public string Manufacturer
        {
            get { return this.manufacturer; }
            set
            {
                if (value!= null && value.Trim().Length == 0)
                {
                    throw new ArgumentException("Invalid argument: Manufacturer should not be empty.");
                }
                this.manufacturer = value;
            }
        }

        public string Processor
        {
            get { return this.processor; }
            set
            {
                if (value != null && value.Trim().Length == 0)
                {
                    throw new ArgumentException("Invalid argument: Processor should not be empty.");
                }
                this.processor = value;
            }
        }

        public int Ram
        {
            get { return this.ram; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Invalid argument: RAM should not be negative.");
                }
                this.ram = value;
            }
        }

        public string GraphicsCard
        {
            get { return this.graphicsCard; }
            set
            {
                if (value != null && value.Trim().Length == 0)
                {
                    throw new ArgumentException("Invalid argument: Graphics card should not be empty.");
                }
                this.graphicsCard = value;
            }
        }

        public string Hdd
        {
            get { return this.hdd; }
            set
            {
                if (value != null && value.Trim().Length == 0)
                {
                    throw new ArgumentException("Invalid argument: HDD should not be empty.");
                }
                this.hdd = value;
            }           
        }

        public string Screen
        {
            get { return this.screen; }
            set
            {
                if (value != null && value.Trim().Length == 0)
                {
                    throw new ArgumentException("Invalid argument: Model should not be empty.");
                }
                this.screen = value;
            }
        }

        public Battery Battery { get; set; }

        public double BatteryLife
        {
            get { return this.batteryLife; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Invalid argument: Battery life should not be negative");
                }
                this.batteryLife = value;
            }
        }

        public decimal Price
        {
            get { return this.price; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Invalid argument: Price should not be negative.");
                }
                this.price = value;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Model: " + this.Model);

            if (this.Manufacturer != null)
            {
                sb.AppendLine("Manufacturer: " + this.Manufacturer);
            }

            if (this.Processor != null)
            {
                sb.AppendLine("Processor: " + this.Processor);
            }

            if (this.Ram != 0)
            {
                sb.AppendLine("RAM: " + this.Ram + " GB");
            }

            if (this.GraphicsCard != null)
            {
                sb.AppendLine("Graphics card: " + this.GraphicsCard);
            }

            if (this.Hdd != null)
            {
                sb.AppendLine("HDD: " + this.Hdd);
            }

            if (this.Screen != null)
            {
                sb.AppendLine("Screen: " + this.Screen);
            }

            if (this.Battery != null)
            {
                sb.AppendLine("Battery: " + this.Battery.ToString());
            }

            if (this.BatteryLife != 0)
            {
                sb.AppendLine("Battery life: " + this.BatteryLife + " hours");
            }

            sb.AppendLine("Price: " + this.Price + " lv.");

            return sb.ToString();
        }
    }
}
