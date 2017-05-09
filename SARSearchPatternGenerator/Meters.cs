using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SARSearchPatternGenerator
{
    class Meters : DistanceUnit
    {
        private static Meters unit;

        private Meters()
        {

        }

        public Meters create()
        {
            if (unit == null)
                unit = new Meters();
            return unit;
        }

        public override double convertTo(double dist)
        {
            return dist * 1000;
        }
    }
}
