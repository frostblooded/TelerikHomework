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
            int k, n;
            do
            {
                Console.WriteLine("n?");
                n = int.Parse(Console.ReadLine());
            } while (n < 1f);
            do
            {
                Console.WriteLine("k?");
                k = int.Parse(Console.ReadLine());
            } while (k < n);
            float nResult = 1, kResult = 1;
            for (int i = 2; i <= n; i++)
            {
                nResult *= i;
            }
            for (int i = 2; i <= k; i++)
            {
                kResult *= i;
            }
            float product = k - n, productResult = k - n;
            for (int i = 2; i <= product; i++)
            {
                productResult *= i;
            }
            float result = (nResult * kResult) / (productResult);
            Console.WriteLine("(n!*k!)/(k-n)! = {0:0.00}", result);
        }
    }
}
