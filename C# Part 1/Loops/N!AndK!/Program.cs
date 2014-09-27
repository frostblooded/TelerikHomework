using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N_AndK_
{
    class Program
    {
        static void Main(string[] args)
        {
            float k, n;
            do
            {
                Console.WriteLine("k?");
                k = float.Parse(Console.ReadLine());
            } while (k < 1f);
            do
            {
                Console.WriteLine("n?");
                n = float.Parse(Console.ReadLine());
            } while (n < k);
            float nResult = 1, kResult = 1;
            for (int i = 2; i <= n; i++)
            {
                nResult *= i;
            }
            for (int i = 2; i <= k; i++)
            {
                kResult *= i;
            }
            float result = nResult / kResult;
            Console.WriteLine("n!/k! = {0:0.00}", result);
        }
    }
}
