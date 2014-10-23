namespace ShapeSystem
{
    public class Rectangle : Shape
    {
        public Rectangle()
        {
            Width = 0;
            Height = 0;
        }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public override double CalculateSurface()
        {
            return Width * Height;
        }
    }
}
