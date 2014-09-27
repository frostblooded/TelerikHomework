using System;
using System.Collections.Generic;

class Program
{
    static int lengthOfVariations;
    static int[] numbers;
    static List<int> currentNumbers = new List<int>();
    static List<List<int>> permutations = new List<List<int>>();

    static void GetPermutations(int currentStartingPosition = 0)
    {
        if (currentNumbers.Count >= lengthOfVariations)
        {
            permutations.Add(new List<int>(currentNumbers));
            return;
        }
        else
        {
            for (int i = currentStartingPosition; i < numbers.Length; i++)
            {
                currentNumbers.Add(numbers[i]);
                GetPermutations(i + 1);
                currentNumbers.RemoveAt(currentNumbers.Count - 1);
            }
        }
    }

    static void Main()
    {
        //Input
        Console.WriteLine("Count of numbers?");
        int length = int.Parse(Console.ReadLine());
        numbers = new int[length];
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine("Contents of cell {0}?", i + 1);
            numbers[i] = int.Parse(Console.ReadLine());
        }
        do
        {
            Console.WriteLine("Length of variations (should be smaller than the count of the numbers)");
            lengthOfVariations = int.Parse(Console.ReadLine());
        } while (lengthOfVariations > numbers.Length);

        //Recursion to get the permutations
        GetPermutations();

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
