using System;
using System.IO;

namespace Figure
{
    public class Triangle : Figure
    {
        public double Side_a { get; set; }
        public double Side_b { get; set; }
        public double Side_c { get; set; }

        public Triangle(double side_a, double side_b, double side_c)
        {
            Side_a = side_a;
            Side_b = side_b;
            Side_c = side_c;

            is_valid();
        }

        public override double Area()
        {
            double p = (Side_a + Side_b + Side_c) / 2;
            return Math.Sqrt(p * (p - Side_a) * (p - Side_b) * (p - Side_c));
        }
        public bool is_rectangular()
        {
            return ((Side_a * Side_a + Side_b * Side_b == Side_c * Side_c) ||
                (Side_a * Side_a + Side_c * Side_c == Side_b * Side_b) ||
                (Side_c * Side_c + Side_b * Side_b == Side_a * Side_a));
        }

        protected void is_valid()
        {
            if ((Side_a > Side_b + Side_c) || (Side_b > Side_a + Side_c) || (Side_c > Side_a + Side_b))
                throw new InvalidOperationException("Incorrect size of the triangle sides");
            if ((Side_a < 0) || (Side_b < 0) || (Side_c < 0))
                throw new InvalidDataException("Side < 0");
        }
    }
}
