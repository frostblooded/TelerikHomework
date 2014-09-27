using System;

namespace CatalanNumbers
{
    class Program
    {
        static ulong CalculateFactorial(ulong number)
        {
            ulong result = 1;
            for (ulong i = 2; i <= number; i++)
            {
                result *= i;
            }
            return result;
        }

        static void Main(string[] args)
        {
            ulong n = 0;
            do
            {
                if (n < 0)
                {
                    Console.WriteLine("The input number should be zero or positive");
                }
                Console.WriteLine("N?");
                n = ulong.Parse(Console.ReadLine());
            } while (n < 0);
            ulong c = 0;
            c = CalculateFactorial(2 * n) / (CalculateFactorial(n + 1) * CalculateFactorial(n));
            Console.WriteLine(c);
        }
    }
}
