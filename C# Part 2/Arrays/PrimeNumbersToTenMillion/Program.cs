using System;

class Program
{
    static void Main()
    {
        bool[] numbers = new bool[10000000];
        for (int i = 2; i < numbers.Length; i++)
        {
            if (!numbers[i])
            {
                Console.WriteLine(i);
                numbers[i] = true;
                int j = 2;
                while (i * j < numbers.Length)
                {
                    numbers[i * j] = true;
                    j++;
                }
            }
        }
    }
}
