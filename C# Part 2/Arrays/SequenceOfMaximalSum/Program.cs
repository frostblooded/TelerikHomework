using System;
using System.Collections.Generic;

class Program
{
    static void CheckUsedNumbers()
    {
        
    }
    static void Main()
    {
        //Input
        Console.WriteLine("Length?");
        int length = int.Parse(Console.ReadLine());
        int[] numbers = new int[length];
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        //Solve
        List<int> usedNumbers = new List<int>();
        List<int> maximalSumNumbers = new List<int>();
        int maximalSum = numbers[0];
        maximalSumNumbers.Add(numbers[0]);
        for (int i = 0; i < numbers.Length; i++)
        {
            for (int j = i; j < numbers.Length; j++)
            {
                usedNumbers.Add(numbers[j]);

                //Check if the numbers' sum is greater than the previously found one
                int sum = 0;
                for (int z = 0; z < usedNumbers.Count; z++)
                {
                    sum += usedNumbers[z];
                }
                if (sum > maximalSum)
                {
                    maximalSum = sum;
                    maximalSumNumbers = new List<int>(usedNumbers);
                }
                
            }
            usedNumbers.Clear();
        }

        //Output
        for (int i = 0; i < maximalSumNumbers.Count; i++)
        {
            Console.Write("{0} ", maximalSumNumbers[i]);
            if (i != maximalSumNumbers.Count - 1)
            {
                Console.Write("+ ");
            }
        }
        Console.Write("= {0}", maximalSum);
    }
}
