using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskFromLectia13
{
    internal class Ellipse
    {
        public int radius { get; set; } = 0;
        public int x { get; } = 0;
        public int y { get; } = 0;

        public Ellipse() { radius = 50; x = 0; y = 0; }
        public Ellipse(int radiust, int xt, int yt) { radius = radiust; x = xt; y = yt; }

        public string GetInfoPos()
        {
            return $"X: {x} Y: {y}";
        }
        public string GetInfoRadius()
        {
            return $"{radius}";
        }
        public string GetSquare()
        {
            return $"{(int)(Math.PI * Math.Pow(radius, 2))}";
        }
        public string GetHeight()
        {
            return $"{(int)(2 * Math.PI * radius)}";
        }
    }
}
