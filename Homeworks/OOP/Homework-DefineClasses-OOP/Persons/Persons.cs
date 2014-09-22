namespace Persons
{
    using System;

    public class Persons
    {
        public static void Main()
        {
            Person firstPerson = new Person("Pesho", 22, "pesho_kirkata@kirka.net");
            Person secondPerson = new Person("Gosho", 20);
            Console.WriteLine(firstPerson);
            Console.WriteLine(secondPerson);
        }
    }
}
