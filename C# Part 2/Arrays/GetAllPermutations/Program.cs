using System;
using System.Collections.Generic;

class Program
{
    static int[] numbers;
    static bool[] used;
    static List<int> currentNumbers = new List<int>();
    static List<List<int>> permutations = new List<List<int>>();

    static void GetPermutations(int currentStartingPosition)
    {
        if (currentStartingPosition >= numbers.Length)
        {
            permutations.Add(new List<int>(currentNumbers));
            return;
        }
        else
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (!used[i])
                {
                    used[i] = true;
                    currentNumbers.Add(numbers[i]);
                    GetPermutations(currentStartingPosition + 1);
                    currentNumbers.RemoveAt(currentNumbers.Count - 1);
                    used[i] = false;
                }
            }
        }
    }
    static void Main()
    {
        //Input
        Console.WriteLine("Length?");
        int length = int.Parse(Console.ReadLine());
        numbers = new int[length];
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine("Contents of cell {0}?", i + 1);
            numbers[i] = int.Parse(Console.ReadLine());
        }

        //Recursion to get the permutations
        used = new bool[length];
        GetPermutations(0);

        //Output
        foreach (var permutation in permutations)
        {
            foreach (var number in permutation)
            {
                Console.Write("{0} ", number);
            }
            Console.WriteLine();
        }
    }
}
