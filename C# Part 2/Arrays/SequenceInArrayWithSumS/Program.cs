using System;
using System.Collections.Generic;

class Program
{
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
        Console.WriteLine("Sum we are looking for?");
        int searchedSum = int.Parse(Console.ReadLine());

        //Solve
        List<int> usedNumbers = new List<int>();
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
                if (sum == searchedSum)
                {
                    //Output
                    for (int z = 0; z < usedNumbers.Count; z++)
                    {
                        Console.Write("{0} ", usedNumbers[z]);
                        if (z != usedNumbers.Count - 1)
                        {
                            Console.Write("+ ");
                        }
                    }
                    Console.Write("= {0}", searchedSum);
                    Environment.Exit(0);
                }
            }
            usedNumbers.Clear();
        }
    }
}

