using System;

namespace FindNFibonacciNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("N?");
            int n = int.Parse(Console.ReadLine());
            int[] number = new int[3];
            number[1] = 1;
            number[2] = 0;
            Console.WriteLine(number[2]);
            Console.WriteLine(number[1]);
            for (int i = 0; i < n; i++)
            {
                number[0] = number[1] + number[2];
                number[2] = number[1];
                number[1] = number[0];
                Console.WriteLine(number[0]);
            }
        }
    }
}
