using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathTaskClassLibrary
{
    public class Geometry
    {
        public int RectangleArea(int a, int b)
        {
            return a * b;
        }
        public double Cylinder_volume(double R, double h)
        {
            return Math.Round(3.14 * Math.Pow(R, 2) * h, 0);
        }
    }
}