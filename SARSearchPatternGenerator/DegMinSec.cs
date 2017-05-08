using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SARSearchPatternGenerator
{
    public class DegMinSec : Coordinate
    {
        protected double latDegrees;
        protected double lngDegrees;
        protected double latMinutes;
        protected double lngMinutes;
        protected double latSeconds;
        protected double lngSeconds;

        public DegMinSec(double latDegrees, double latMinutes, double latSeconds,
            double lngDegrees, double lngMinutes, double lngSeconds)
        {
            this.latDegrees = latDegrees;
            this.latMinutes = latMinutes;
            this.latSeconds = latSeconds;
            this.lngDegrees = lngDegrees;
            this.lngMinutes = lngMinutes;
            this.lngSeconds = lngSeconds;

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

        public double getLatSec()
        {
            return latSeconds;
        }

        public double getLngSec()
        {
            return lngSeconds;
        }

        public override void fromBase()
        {
            latDegrees = (int)latitude;
            latMinutes = (latitude - latDegrees) * 60;
            latSeconds = latMinutes;
            latMinutes = (int)latMinutes;
            latSeconds = (latSeconds - latMinutes) * 60;
            
            lngDegrees = (int)longitude;
            lngMinutes = (longitude - lngDegrees) * 60;
            lngSeconds = lngMinutes;
            lngMinutes = (int)lngMinutes;
            lngSeconds = (lngSeconds - lngMinutes) * 60;
        }

        public override void toBase()
        {
            latitude = (latSeconds / 60 + latMinutes) / 60 + latDegrees;

            longitude = (lngSeconds / 60 + lngMinutes) / 60 + lngDegrees;
        }
    }
}
