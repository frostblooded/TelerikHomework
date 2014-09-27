using System;

namespace ZeroesAtTheEndOfFactorial
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("N?");
            int n = int.Parse(Console.ReadLine());
            int counter = 0;
            while (n % 5 != 0)
            {
                n--;
            }
            while (n != 0)
            {
                if (n % 25 == 0)
                {
                    counter += 2;
                }
                else
                {
                    counter++;
                }
                n -= 5;
            }
            Console.WriteLine(counter);
        }
    }
}
