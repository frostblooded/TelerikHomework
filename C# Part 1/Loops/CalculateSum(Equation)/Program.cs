using System;

namespace CalculateSum_Equation_
{
    class Program
    {
        static double CalculateFactorial(int number)
        {
            int result = 1;
            for (int i = 2; i <= number; i++)
            {
                result *= i;
            }
            return result;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("X?");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("N?");
            int n = int.Parse(Console.ReadLine());
            double s = 1;
            for (int i = 1; i <= n; i++)
            {
                s += CalculateFactorial(i) / Math.Pow(x, i);
            }
            Console.WriteLine(s);
        }
    }
}
