using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SARSearchPatternGenerator
{
    public class DegDecMin : Coordinate
    {
        protected double latDegrees;
        protected double lngDegrees;
        protected double latMinutes;
        protected double lngMinutes;

        public DegDecMin(double latDegrees, double latMinutes, double lngDegrees, double lngMinutes)
        {
            this.latDegrees = latDegrees;
            this.latMinutes = latMinutes;
            this.lngDegrees = lngDegrees;
            this.lngMinutes = lngMinutes;

            toBase();
        }

        public double getLatDeg()
        {
            return latDegrees;
        }

        public double getLngDeg()
        {
            return lngDegrees;
        }

        public double getLatMin()
        {
            return latMinutes;
        }

        public double getLngMin()
        {
            return lngMinutes;
        }

        public override void fromBase()
        {
            latDegrees = (int)latitude;
            latMinutes = (latitude - latDegrees) * 60;

            lngDegrees = (int)longitude;
            lngMinutes = (longitude - lngDegrees) * 60;
        }

        public override void toBase()
        {
            latitude = latMinutes / 60 + latDegrees;

            longitude = lngMinutes / 60 + lngDegrees;
        }
    }
}
