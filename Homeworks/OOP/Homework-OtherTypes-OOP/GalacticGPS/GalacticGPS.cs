namespace GalacticGPS
{
    using System;

    class GalacticGPS
    {
        static void Main()
        {
            Location Sofiq = new Location(11.2, 22.4, Planet.Earth);
            Console.WriteLine(Sofiq);
        }
    }
}
