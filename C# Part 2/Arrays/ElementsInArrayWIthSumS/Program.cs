using System;
using System.Collections.Generic;
class IsThereSumS
{
    static int[] numbers;
    static List<List<int>> combinations;
    static List<int> currentCombination;

    static void GetCombinations(int currentPosition)
    {
        for (int i = currentPosition; i < numbers.Length; i++)
        {
            currentCombination.Add(numbers[i]);
            combinations.Add(new List<int>(currentCombination));
            if (currentPosition != numbers.Length - 1)
            {
                GetCombinations(i + 1);
            }
            currentCombination.RemoveAt(currentCombination.Count - 1);
        }
    }

    static void Main()
    {
        currentCombination = new List<int>();
        combinations = new List<List<int>>();

        //Input
        Console.WriteLine("Length?");
        int length = int.Parse(Console.ReadLine());
        numbers = new int[length];
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine("Contents of cell {0}?", i + 1);
            numbers[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Which is the sum we are looking for?");
        int searchedSum = int.Parse(Console.ReadLine());

        //Recursion Call
        GetCombinations(0);

        //Check the sum of each combination
        List<int> checkedNumbers = new List<int>();
        int currentSum = 0;
        bool found = false;
        foreach (var item in combinations)
        {
            checkedNumbers.Clear();
            currentSum = 0;
            foreach (var integer in item)
            {
                checkedNumbers.Add(integer);
                currentSum += integer;
            }
            if (currentSum == searchedSum)
            {
                found = true;
                for (int i = 0; i < checkedNumbers.Count; i++)
                {
                    Console.Write(checkedNumbers[i]);
                    if (i == checkedNumbers.Count - 1)
                    {
                        Console.WriteLine(" = {0}", searchedSum);
                    }
                    else
                    {
                        Console.Write(" + ");
                    }
                }
            }
        }
        if (!found)
        {
            Console.WriteLine("There are no combinations with this sum.");
        }
        Console.WriteLine("Press any key to continue . . .");
        Console.ReadLine();
    }
}