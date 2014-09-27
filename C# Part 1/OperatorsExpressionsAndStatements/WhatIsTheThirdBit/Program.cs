using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatIsTheThirdBit
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 11119;
            a = a >> 3;
            a = a & 1;
            Console.WriteLine(a);
        }
    }
}
