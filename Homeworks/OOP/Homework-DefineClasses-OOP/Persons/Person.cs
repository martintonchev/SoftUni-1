namespace Persons
{
    using System;

    class Person
    {
        private string name;
        private int age;
        private string email;

        public string Name
        {
            get { return this.name; }
            set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name is empty!");
                }
                this.name = value; 
            }
        }

        public int Age 
        {
            get { return this.age; }
            set 
            {
                if (value < 1 || value > 100)
                {
                    throw new ArgumentOutOfRangeException("Age must be in range [1..100]");
                }
                this.age = value;
            }
        }

        public string Email 
        {
            get { return this.email; }
            set 
            {
                if (value != null && !value.Contains("@"))
                {
                    throw new ArgumentException("Invalid email address!");
                }
                this.email = value;
            }
        }

        public Person(string name, int age, string email)
        {
            this.Name = name;
            this.Age = age;
            this.Email = email;
        }

        public Person(string name, int age)
            : this(name, age, null)
        { }

        public override string ToString()
        {
            string result = string.Format("Name: {0}, age: {1}", this.Name, this.Age);
            if (this.Email != null)
            {
                result += string.Format(", email: {0}", this.Email);
            }
            return result;
        }
    }
}
