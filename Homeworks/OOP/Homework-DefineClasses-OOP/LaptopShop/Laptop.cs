namespace LaptopShop
{
    using System;

    class Laptop
    {
        private string model;
        private string manufacturer;
        private string processor;
        private string ram;
        private string graphicscard;
        private string hdd;
        private string screen;
        private Battery battery;
        private decimal price;

        public string Model 
        {
            get { return this.model; }
            set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Model should not be empty!");
                }
                this.model = value;
            }
        }

        public string Manufacturer
        {
            get { return this.manufacturer; }
            set 
            {
                if (value != null && value.Length < 1)
                {
                    throw new ArgumentException("Invalid value for manufacturer!");
                }
                this.manufacturer = value;
            }
        }

        public string Processor
        {
            get { return this.processor; }
            set 
            {
                if (value != null && value.Length < 1)
                {
                    throw new ArgumentException("Invalid value for procesoor!");
                }
                this.processor = value;
            }
        }

        public string RAM 
        {
            get { return this.ram; }
            set 
            {
                if (value != null && value.Length < 1)
                {
                    throw new ArgumentException("Invalid value for RAM!");
                }
                this.ram = value;
            }
        }

        public string GraphicsCard
        {
            get { return this.graphicscard; }
            set 
            {
                if (value != null && value.Length < 1)
                {
                    throw new ArgumentException("Invalid value for graphicscard!");
                }
                this.graphicscard = value;
            }
        }

        public string HDD
        {
            get { return this.hdd; }
            set 
            {
                if (value != null && value.Length < 1)
                {
                    throw new ArgumentException("Invalid value for HDD");
                }
                this.hdd = value;
            }
        }

        public string Screen
        {
            get { return this.screen; }
            set 
            {
                if (value != null && value.Length < 1)
                {
                    throw new ArgumentException("Invalid value for screen!");
                }
                this.screen = value;
            }
        }

        public Battery Battery
        {
            get { return this.battery; }
            set { this.battery = value; }
        }

        public decimal Price
        {
            get { return this.price; }
            set 
            {
                if (value < 0)
                {
                    throw new ArgumentException("Price cannot be negative");
                }
                this.price = value;
            }
        }

        public Laptop(string model, string manufacturer, string processor, string ram, string graphicscard, string hdd, string screen, Battery battery, decimal price)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Processor = processor;
            this.RAM = ram;
            this.GraphicsCard = graphicscard;
            this.HDD = hdd;
            this.Screen = screen;
            this.Battery = battery;
            this.Price = price;
        }

        public Laptop(string model, decimal price) :this(model, null, null, null, null, null, null, null, price)
        { }

        public override string ToString()
        {
            string result = string.Format("Model: {0}", this.Model);
            if (this.Manufacturer != null)
            {
                result += string.Format(", manufacturer: {0}", this.Manufacturer);
            }
            if (this.Processor != null)
            {
                result += string.Format(", procesoor: {0}", this.Processor);
            }
            if (this.RAM != null)
            {
                result += string.Format(", RAM: {0}", this.RAM); 
            }
            if (this.GraphicsCard != null)
            {
                result += string.Format(", graphicscard: {0}", this.GraphicsCard);
            }
            if (this.HDD != null)
            {
                result += string.Format(", HDD: {0}", this.HDD);
            }
            if (this.Screen != null)
            {
                result += string.Format(", screen: {0}", this.Screen);
            }
            if (this.Battery != null)
            {
                result += string.Format(", battery: {0}", this.Battery);
            }
            result += string.Format(", price: {0}", this.Price);
            return result;
        }
    }
}
