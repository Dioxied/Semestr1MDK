namespace MathTaskClassLibrary
{
    public class Geometry
    {
        public int S(int a ,int b)
        {
            return a * b;
        }
    }

    public class rectangle_perimeter
    {
        public int P(int a, int b)
        {
            return a * 2 + b * 2;
        }
    }

    public class cylinder_volume
    {
        public int V(int R, int h)
        {
            return (int)(Math.PI * Math.Pow(R, 2) * h);
        }
    }

    public class VSr
    {
        public int V(int a, int b, int c)
        {
            return a * b * c;
        }
        public int S(int a, int b, int c)
        {
            return 2 * (a * b + b * c + a * c);
        }
    }
}
