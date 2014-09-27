using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersDivisableBy5
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int p = 0;
            if (b > a)
            {
                for (int i = a; i <= b; i++)
                {
                    if (i % 5 == 0)
                    {
                        p++;
                    }
                }
            }
            else
            {
                for (int i = b; i <= a; i++)
                {
                    if (i % 5 == 0)
                    {
                        p++;
                    }
                }
            }
            Console.WriteLine(p);
        }
    }
}
