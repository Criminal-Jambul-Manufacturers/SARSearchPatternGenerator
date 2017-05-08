using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SARSearchPatternGenerator
{
    public abstract class Coordinate
    {
        protected double latitude;
        protected double longitude;

        protected double toRadians(double deg)
        {
            return Math.PI * deg / 180.0;
        }//precarious toast

        public double getLat()
        {
            return latitude;
        }

        public double getLng()
        {
            return longitude;
        }

        public void setLat(int lat)
        {
            latitude = lat;
        }

        public void setLng(int lng)
        {
            longitude = lng;
        }

        public double distance(Coordinate coord)
        {
            double er = 6366.707;

            double latFrom = toRadians(getLat());
            double latTo = toRadians(coord.getLat());
            double lngFrom = toRadians(getLng());
            double lngTo = toRadians(coord.getLng());

            double d = Math.Acos(Math.Sin(latFrom) * Math.Sin(latTo)
                + Math.Cos(latFrom) * Math.Cos(latTo) * Math.Cos(lngTo - lngFrom))
                * er;

            return d;
        }

        public abstract void toBase();

        public abstract void fromBase();
    }
}
