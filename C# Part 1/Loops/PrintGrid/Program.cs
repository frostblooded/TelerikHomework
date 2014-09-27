using System;

namespace PrintGrid
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("N?");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                for (int j = i; j <= n + (i - 1); j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }
}
