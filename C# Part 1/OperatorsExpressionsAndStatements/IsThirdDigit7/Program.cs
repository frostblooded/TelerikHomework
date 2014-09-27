using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsThirdDigit7
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 95766;
            for (int i = 0; i < 2; i++)
            {
                a = a / 10;
            }
            bool thirdNumberIsSeven = a % 10 == 7;
            Console.WriteLine(thirdNumberIsSeven);
        }
    }
}
