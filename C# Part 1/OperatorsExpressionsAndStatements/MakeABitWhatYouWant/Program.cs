using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeABitWhatYouWant
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 5, p = 2, v = 0;
            if (v == 1)
            {
                int mask = 1 << p;
                n = n | mask;
            }
            else
            {
                int mask = ~(1 << p);
                n = n & mask;
            }
            Console.WriteLine(n);
        }
    }
}
