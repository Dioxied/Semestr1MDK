using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathTaskClassLibrary;

namespace MathTaskClassLibraryTests
{
    [TestClass]
    public class GepmetryTest
    {
        [TestMethod]
        public void RestangleArea_3and5_15returned()
        {
            int a = 3, b = 5, expected = 15;

            Geometry g = new Geometry();
            int actual = g.RectangleArea(a, b);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void RestangleArea_4and5_20returned()
        {
            int a = 4, b = 5, expected = 20;

            Geometry g = new Geometry();
            int actual = g.RectangleArea(a, b);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Cylinder_volume_6and5_471_239returned()
        {
            double a = 5, b = 6, expected = 471;

            Geometry g = new Geometry();
            double actual = g.Cylinder_volume(a, b);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Cylinder_volume_10and9_2_2544_69returned()
        {
            double a = 9, b = 10, expected = 2543;

            Geometry g = new Geometry();
            double actual = g.Cylinder_volume(a, b);

            Assert.AreEqual(expected, actual);
        }
    }
}
