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

    static bool IsTheListSorted(List<int> checkedList)
    {
        for (int i = 1; i < checkedList.Count; i++)
        {
            if (checkedList[i] < checkedList[i - 1])
            {
                return false;
            }
        }
        return true;
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

        //Recursion Call
        GetCombinations(0);

        //Find Longest Sorted Array
        List<int> longestFoundSortedList = new List<int>();
        foreach (var item in combinations)
        {
            if (IsTheListSorted(item) && item.Count > longestFoundSortedList.Count)
            {
                longestFoundSortedList = new List<int>(item);
            }
        }
        Console.WriteLine();
        if (longestFoundSortedList.Count < 0)
        {
            Console.WriteLine("No increasing array possible.");
        }
        else
        {
            foreach (var item in longestFoundSortedList)
            {
                Console.WriteLine(item);
            }
        }
    }
}