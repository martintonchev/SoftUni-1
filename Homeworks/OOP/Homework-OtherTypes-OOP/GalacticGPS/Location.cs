namespace GalacticGPS
{
    using System;

    struct Location
    {
        private double latitude;
        private double longitude;
        private Planet planet;

        public double Latitude
        {
            get { return this.latitude; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Value for latitude should be positive!");
                }
                this.latitude = value;
            }
        }
        public double Longitude
        {
            get { return this.longitude; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Value for longitude should be positive!");
                }
                this.longitude = value;
            }
        }

        public Planet Planet
        {
            get { return this.planet; }
            set { this.planet = value; }
        }

        public Location(double latitude, double longitude, Planet planet)
            : this()
        {
            this.Latitude = latitude;
            this.Longitude = longitude;
            this.Planet = planet;
        }

        public override string ToString()
        {
            return string.Format("{0}, {1} - {2}",
                this.Latitude, this.Longitude, this.Planet);
        }
    }
}
