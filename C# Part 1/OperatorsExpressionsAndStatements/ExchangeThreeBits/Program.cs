using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeThreeBits
{
    class Program
    {
        static void Main(string[] args)
        {
            uint n = 56, firstGettingMask, secondGettingMask, placementMask;
            for (int i = 3; i < 6; i++)
            {
                firstGettingMask = n;
                firstGettingMask = firstGettingMask >> i;
                firstGettingMask = firstGettingMask & 1;
                secondGettingMask = n;
                secondGettingMask = secondGettingMask >> (i + 21);
                secondGettingMask = secondGettingMask & 1;
                if (firstGettingMask == 1)
                {
                    placementMask = (uint)(1 << (i + 21));
                    n = n | placementMask;
                }
                else
                {
                    placementMask = ~(uint)(1 << (i + 21));
                    n = n & placementMask;
                }
                if (secondGettingMask == 1)
                {
                    placementMask = (uint)(1 << i);
                    n = n | placementMask;
                }else
                {
                    placementMask = ~(uint)(1 << i);
                    n = n & placementMask;
                }
            }
            Console.WriteLine(n);
        }
    }
}
