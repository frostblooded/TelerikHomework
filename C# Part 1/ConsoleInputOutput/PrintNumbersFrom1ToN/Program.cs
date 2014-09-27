using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintNumbersFrom1ToN
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Which is the last printed number?");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(i + 1);
            }
        }
    }
}
