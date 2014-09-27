using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadraticEquation
{
    class Program
    {
        static void Main(string[] args)
        {
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
                        Console.WriteLine("There is no real solution.");
                    }
                }
                else
                {
                    Console.WriteLine("The only solution is {0}", -(c / b));
                }
            }
            else
            {
                double d = Math.Pow(b, 2) - 4 * a * c;
                if (d > 0)
                {
                    double x1 = (-b + Math.Sqrt(d)) / 2 * a;
                    double x2 = (-b - Math.Sqrt(d)) / 2 * a;
                    Console.WriteLine("The first solution is {0:0.00} and the second one is {1:0.00}", x1, x2);
                }
                else
                {
                    Console.WriteLine("There are no real solutions.");
                }
            }
        }
    }
}
