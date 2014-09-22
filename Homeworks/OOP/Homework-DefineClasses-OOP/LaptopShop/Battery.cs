namespace LaptopShop
{
    using System;

    class Battery
    {
        private string type;
        private decimal batterylifehours;

        public string Type
        {
            get { return this.type; }
            set 
            {
                if (value != null && value.Length < 1)
                {
                    throw new ArgumentException("Invalid value for type!");
                }
                this.type = value;
            }
        }

        public decimal BatteryLifeHours
        {
            get { return this.batterylifehours; }
            set 
            {
                if (value < 0)
                {
                    throw new ArgumentException("Life in hours cannot be negative!");
                }
                this.batterylifehours = value;
            }
        }

        public Battery(string type, decimal batterylifehours)
        {
            this.Type = type;
            this.BatteryLifeHours = batterylifehours;
        }

        public Battery(string type)
            : this(type, 0)
        { }

        public override string ToString()
        {
            string result = null;
            if (this.Type != null)
            {
                result += string.Format("Type: {0}", this.Type);
            }
            if (this.BatteryLifeHours > 0)
            {
                result += string.Format(" BatteryLifeHours: {0}", this.BatteryLifeHours.ToString());
            }
            return result;
        }
    }
}
