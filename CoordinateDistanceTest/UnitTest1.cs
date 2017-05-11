using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SARSearchPatternGenerator;

namespace CoordinateDistanceTest
{
    [TestClass]
    public class UnitTest1
    {
        Coordinate coords1, coords2;

        [TestMethod]
        public void TestMethod1()
        {
            double expected = 1769;

            coords1 = new DegDecMin(73, 4, 55, 55); //=73.0667, 55.9167
            coords2 = new DegMinSec(57, 19, 12, 49, 59, 33); //=57.3200, 49.9925

            double actual = coords1.distance(coords2);
            Assert.AreEqual(expected, actual, 1, "You dun goofed");
        }

        [TestMethod]
        public void TestMethod2()
        {
            double expected = 7926;

            coords1 = new UTMCoord(18, 'T', 27103.1, 84335.4);
            coords2 = new DegMinSec(57, 19, 12, 49, 59, 33); //=57.3200, 49.9925

            double actual = coords1.distance(coords2);
            Assert.AreEqual(expected, actual, 1, "You dun goofed");
        }
    }
}
