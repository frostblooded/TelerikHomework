namespace ShapeSystem
{
    public class Triangle : Shape
    {
        public Triangle()
        {
            Width = 0;
            Height = 0;
        }

        public Triangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public override double CalculateSurface()
        {
            return (Width * Height) / 2;
        }
    }
}
