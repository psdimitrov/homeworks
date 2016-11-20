using System;

namespace _1_GalacticGPS
{
    public struct Location
    {
        private const int MinLatitude = -90;
        private const int MaxLatitude = 90;
        private const int MinLongitude = -180;
        private const int MaxLongitude = 180;

        private double latitude;
        private double longitude;
        private Planet planetName;

        public Location(
            double latitude,
            double longitude,
            Planet planet)
            : this()
        {
            this.Latitude = latitude;
            this.Longitude = longitude;
            this.PlanetName = planet;
        }

        public double Latitude
        {
            get
            {
                return this.latitude;
            }

            private set
            {
                if (value < MinLatitude || value > MaxLatitude)
                {
                    throw new ArgumentOutOfRangeException("Latitude", "Latitude should be between -90 and 90");
                }

                this.latitude = value;
            }
        }

        public double Longitude
        {
            get
            {
                return this.longitude;
            }

            private set
            {
                if (value < MinLongitude || value > MaxLongitude)
                {
                    throw new ArgumentOutOfRangeException("Longitude", "Longitude should be between -180 and 180");
                }

                this.longitude = value;
            }
        }

        public Planet PlanetName
        {
            get
            {
                return this.planetName;
            }

            private set
            {               
                this.planetName = value;
            }
        }

        public override string ToString()
        {
            return string.Format("{0}, {1} - {2}", this.latitude, this.longitude, this.PlanetName.ToString());
        }
    }
}