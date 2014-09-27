using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintFirst100FIbonacciNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            uint a = 0, b = 1, c = 0;
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(a);
                a = b + c;
                c = b;
                b = a;
            }
        }
    }
}
