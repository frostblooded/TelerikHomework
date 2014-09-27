using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CirclePerimeterAndArea
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the readius of the circle?");
            int r = int.Parse(Console.ReadLine());
            Console.WriteLine("The circle's perimeter is {0:F2}", 2 * Math.PI * r);
            Console.WriteLine("The circle's area is {0:F2}", Math.PI * Math.Pow(r, 2));
        }
    }
}
