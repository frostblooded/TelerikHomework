using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            int circleCenterX = 1, circleCenterY = 1, circleRadius = 3;
            double x = 1, y = 2.5;
            bool withinCircle = Math.Sqrt(Math.Pow(x - circleCenterX, 2) + Math.Pow(y - circleCenterY, 2))  < circleRadius;
            Console.WriteLine(withinCircle);
        }
    }
}
