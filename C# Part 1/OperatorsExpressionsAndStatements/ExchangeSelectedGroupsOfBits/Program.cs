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
            int exchangedBitsCount = 5, firstGroupStart = 3, secondGroupStart = 10;
            uint n = 8, firstGettingMask, secondGettingMask, placementMask;
            for (int i = 0; i < exchangedBitsCount; i++)
            {
                firstGettingMask = n;
                firstGettingMask = firstGettingMask >> firstGroupStart + i;
                firstGettingMask = firstGettingMask & 1;
                secondGettingMask = n;
                secondGettingMask = secondGettingMask >> secondGroupStart + i;
                secondGettingMask = secondGettingMask & 1;
                if (firstGettingMask == 1)
                {
                    placementMask = (uint)(1 << (secondGroupStart + i));
                    n = n | placementMask;
                }
                else
                {
                    placementMask = ~(uint)(1 << (secondGroupStart + i));
                    n = n & placementMask;
                }
                if (secondGettingMask == 1)
                {
                    placementMask = (uint)(1 << (firstGroupStart + i));
                    n = n | placementMask;
                }
                else
                {
                    placementMask = ~(uint)(1 << (firstGroupStart + i));
                    n = n & placementMask;
                }
            }
            Console.WriteLine(n);
        }
    }
}
