using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreaterOf2Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a,b,c dividing them with an Enter");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            if (a == 0)
            {
                if (b == 0)
                {
                    if (c == 0)
                    {
                        Console.WriteLine("Every X is a solution.");
                    }
                    else
                    {
                        Console.WriteLine("There is no solution.");
                    }
                }
                else
                {
                    Console.WriteLine("x = {0:F2}", c / b);
                }
            }
            else
            {
                double d = Math.Pow(b, 2) - 4 * a * c;
                if (d < 0)
                {
                    Console.WriteLine("There are no real solutions.");
                }
                else
                {
                    Console.WriteLine("x1 = {0:F2}", ((-b + Math.Sqrt(d)) / (2 * a)));
                    Console.WriteLine("x1 = {0:F2}", ((-b - Math.Sqrt(d)) / (2 * a)));
                }
            }
        }
    }
}
