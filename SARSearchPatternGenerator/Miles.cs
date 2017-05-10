﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SARSearchPatternGenerator
{
    class Miles : DistanceUnit
    {
        private static Miles unit;

        private Miles()
        {

        }

        public Miles create()
        {
            if (unit == null)
                unit = new Miles();
            return unit;
        }

        public override double convertTo(double dist)
        {
            return dist * 0.621371;
        }
    }
}
