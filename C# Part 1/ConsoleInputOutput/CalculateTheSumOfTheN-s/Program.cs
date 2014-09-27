using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateTheSumOfTheN_s
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many numbers will you input?");
            int n = int.Parse(Console.ReadLine());
            int result = 0;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Input number {0}", i + 1);
                result += int.Parse(Console.ReadLine());
            }
            Console.WriteLine(result);
        }
    }
}
