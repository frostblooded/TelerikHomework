using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeValues
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            if (a > b)
            {
                a = a + b;
                b = a - b;
                a = a - b;
            }
            Console.WriteLine("A = {0}, B = {1}", a, b);
        }
    }
}
