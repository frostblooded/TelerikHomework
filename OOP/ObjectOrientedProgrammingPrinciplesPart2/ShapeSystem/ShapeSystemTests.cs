using System;
using System.Collections.Generic;

namespace ShapeSystem
{
    public class ShapeSystemTests
    {
        public static void PrintTestResults(int testsCount)
        {
            for (int i = 0; i < testsCount; i++)
            {
                var shapes = new List<Shape>
                {
                    new Circle(3),
                    new Triangle(3, 5),
                    new Rectangle(7, 1),
                    new Circle(2),
                    new Triangle(12, 3),
                    new Rectangle(16, 4),
                    new Circle(35),
                    new Triangle(6, 8),
                    new Rectangle(3, 5),
                    new Circle(19),
                    new Triangle(2, 9)
                };

                foreach (var shape in shapes)
                {
                    if (shape is Circle)
                    {
                        if (shape.CalculateSurface() != Math.PI * Math.Pow(shape.Width, 2))
                        {
                            throw new ArithmeticException("The received output is unexpected!");
                        }
                    } 
                    else if (shape is Triangle)
                    {
                        if (shape.CalculateSurface() != (shape.Width * shape.Height) / 2)
                        {
                            throw new ArithmeticException("The received output is unexpected!");
                        }
                    } 
                    else if (shape is Rectangle)
                    {
                        if (shape.CalculateSurface() != shape.Width * shape.Height)
                        {
                            throw new ArithmeticException("The received output is unexpected!");
                        }
                    }
                }
            }
        }
    }
}
