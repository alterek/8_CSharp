using System;
using System.IO;

namespace Figure
{
    public class Circle : Figure
    {
        public double Radius { get; set; }
        public Circle(double radius)
        {
            Radius = radius;

            is_valid();
        }
        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }
        protected void is_valid()
        {
            
            if (Radius < 0)
                throw new InvalidDataException("Radius < 0");
        }
    }
}
