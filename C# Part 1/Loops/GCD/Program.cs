using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCD
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input numbers 1 and 2.(one at a time)");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int r, q;
            if (a < b)
            {
                int exhanger = a;
                a = b;
                b = exhanger;
            }
            while (true)
            {
                r = a % b;
                q = a / b;
                if (r == 0)
                {
                    break;
                }
                a = b;
                b = r;
            }
            Console.WriteLine(b);
        }
    }
}
