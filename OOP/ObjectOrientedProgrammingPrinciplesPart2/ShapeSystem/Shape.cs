using System;

namespace ShapeSystem
{
    public abstract class Shape : ISurfaceCalculable
    {
        protected double width;
        protected double height;

        public double Width
        {
            get
            {
                return width;
            }
            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentNullException("The width of the triangle can't be 0 or below!");
                }
                else
                {
                    width = value;
                }
            }
        }

        public double Height
        {
            get
            {
                return height;
            }
            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentNullException("The height of the triangle can't be 0 or below!");
                }
                else
                {
                    height = value;
                }
            }
        }

        public abstract double CalculateSurface();
    }
}
