using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinAndMax
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many numbers will you input?");
            int count = int.Parse(Console.ReadLine());
            int number = 0, min = 0, max = 0;
            for (int i = 0; i < count; i++)
            {
                number = int.Parse(Console.ReadLine());
                if (i == 0)
                {
                    min = number;
                }
                if (number > max)
                {
                    max = number;
                }
                if (number < min)
                {
                    min = number;
                }
            }
            Console.WriteLine("Min: {0}", min);
            Console.WriteLine("Max: {0}", max);
        }
    }
}
