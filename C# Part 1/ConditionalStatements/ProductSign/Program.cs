using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductSign
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int minusesCount = 0;
            if (a < 0)
            {
                minusesCount++;
            }
            if (b < 0)
            {
                minusesCount++;
            }
            if (c < 0)
            {
                minusesCount++;
            }
            if (a == 0 || b == 0 || c == 0)
            {
                minusesCount = -1;
            }
            if (minusesCount % 2 == 0)
            {
                Console.WriteLine("The product will be a positive number.");
            }
            else if (minusesCount >= 0)
            {
                Console.WriteLine("The product will be a negative number.");
            }
            else if (minusesCount == -1)
            {
                Console.WriteLine("The result will be 0.");
            }
        }
    }
}
