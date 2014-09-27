using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreatestOfFiveVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Input number {0}", i);
                a[i] = int.Parse(Console.ReadLine());
            }
            int biggestNumber = a[0];
            for (int i = 0; i < 5; i++)
            {
                if (a[i] > biggestNumber)
                {
                    biggestNumber = a[i];
                }
            }
            Console.WriteLine("THe biggest number is {0}", biggestNumber);
        }
    }
}
