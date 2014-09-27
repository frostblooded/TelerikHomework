using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsideCircleAndOutsideRectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int circleCenterX = 1, circleCenterY = 1, circleRadius = 3;
            double x = -1, y = 1;
            bool inTheRightPlace = (Math.Sqrt(Math.Pow(x - circleCenterX, 2) + Math.Pow(y - circleCenterY, 2)) < circleRadius);
            if (((x >= - 1) && (x <= 5)) && ((y <= 1) && (y >= -1)))
            {
                inTheRightPlace = false;
            }
            Console.WriteLine(inTheRightPlace);
        }
    }
}
