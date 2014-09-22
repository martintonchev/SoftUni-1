namespace LaptopShop
{
    using System;

    class LaptopShop
    {
        static void Main()
        {
            Battery lion = new Battery("lion", 5);
            Laptop firstLaptop = new Laptop("Lenovo-Yoga", "Lenovo", "Dual core 2 Duo", "8GB", "G-Force", "1TB", "21 inch", lion, 1000);
            Laptop secondLaptop = new Laptop("Hp-Aspire", 1000);
            Console.WriteLine(firstLaptop);
            Console.WriteLine(secondLaptop);
        }
    }
}
