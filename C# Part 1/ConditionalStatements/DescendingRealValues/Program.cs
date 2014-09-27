using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DescendingRealValues
{
    class Program
    {
        static void Main(string[] args)
        {
            float a = float.Parse(Console.ReadLine());
            float b = float.Parse(Console.ReadLine());
            float c = float.Parse(Console.ReadLine());
            if (c > b)
            {
                b = b + c;
                c = b - c;
                b = b - c;
            }
            if (b > a)
            {
                a = a + b;
                b = a - b;
                a = a - b;
            }
            if (c > b)
            {
                b = b + c;
                c = b - c;
                b = b - c;
            }
            Console.WriteLine("A = {0}; B = {1}, C = {2}", a, b, c);
        }
    }
}
