using System;
using System.Collections.Generic;
using System.Linq;


namespace PC_Catalog
{
    class Component
    {
        private string name;
        private string details;
        private decimal price;

        public Component(string name, decimal price, string details = null)
        {
            this.Name = name;
            this.Details = details;
            this.Price = price;
        }

        public Component(string name, decimal price)
        {
            this.Name = name;
            this.Price = price;
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                Validation.IsStringEmpty(value, "part name");
                this.name = value;
            }
        }

        public decimal Price
        {
            get { return this.price; }
            set
            {
                Validation.IsNumberNegative(value, "price");
                this.price = value;
            }
        }

        public string Details
        {
            get { return this.details; }
            set
            {
                Validation.IsStringEmpty(value, "details");
                this.details = value;
            }
        }



    }
}