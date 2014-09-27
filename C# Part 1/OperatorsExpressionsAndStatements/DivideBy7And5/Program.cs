using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivideBy7And5
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 35;
            bool dividable = (a % 5 == 0) && (a % 7 == 0);
            Console.WriteLine(dividable);
        }
    }
}
