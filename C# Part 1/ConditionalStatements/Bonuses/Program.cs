using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonuses
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter score.");
            int score = int.Parse(Console.ReadLine());
            Console.WriteLine("Input digit for a multiplier.");
            int digit = int.Parse(Console.ReadLine());
            switch(digit)
            {
                case 1:
                case 2:
                case 3:
                    score *= 10;
                    break;
                case 4:
                case 5:
                case 6:
                    score *= 100;
                    break;
                case 7:
                case 8:
                case 9:
                    score *= 1000;
                    break;
                default:
                    Console.WriteLine("Invalid multiplier digit.");
                    break;
            }
            Console.WriteLine(score);
        }
    }
}
