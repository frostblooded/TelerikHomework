using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubstractBits
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 8, b = 3;
            i = i >> b;
            i = i & 1;
            Console.WriteLine(i);
        }
    }
}
