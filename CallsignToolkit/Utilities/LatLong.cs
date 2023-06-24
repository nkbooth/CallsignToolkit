using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallsignToolkit.Utilities
{
    public struct LatLong
    {
        public double Latitude { get { return latitude; } set { latitude = value; } }
        public double Longitude { get { return longitude; } set { longitude = value; } }

        private double latitude;
        private double longitude;

        public LatLong() { }
        public LatLong(double lat, double lon)
        {
            Latitude = lat;
            Longitude = lon;
        }

        public LatLong(string lat, string lon)
        {
            Latitude = double.Parse(lat);
            Longitude = double.Parse(lon);
        }
    }
}
