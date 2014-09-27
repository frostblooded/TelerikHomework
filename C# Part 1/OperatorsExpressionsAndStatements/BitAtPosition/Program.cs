using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitAtPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            int p = 4, v = 16;
            v = v >> p;
            v = v & 1;
            bool zeroAtPosition = v == 1;
            Console.WriteLine(zeroAtPosition);
        }
    }
}
