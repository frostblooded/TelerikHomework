using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsNPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 43;
            int i = 1;
            if (a != 1)
            {
                do
                {
                    i++;
                } while (a % i != 0); 
            } 
            bool prime = (a == i) || (a == 1);
            Console.WriteLine(prime);
        }
    }
}
