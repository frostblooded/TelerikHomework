using System;

namespace ShapeSystem
{
    public class Circle  : Shape
    {
        public Circle()
        {
            Width = 0;
            Height = Width;
        }

        public Circle(double radius)
        {
            Width = radius;
            Height = Width;
        }

        public override double CalculateSurface()
        {
            return Math.PI * Math.Pow(Width, 2);
        }
    }
}
