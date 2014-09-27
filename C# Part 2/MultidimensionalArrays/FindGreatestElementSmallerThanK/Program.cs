using System;

class Program
{
    static void Main()
    {
        //Input
        int[] numbers = new int[10] { 5, 6, 3, 2, 7, 4, 34, 23, 45, 3 };
        int searchedNumber = 10;
        
        Array.Sort(numbers);
        for (int i = searchedNumber; i >= numbers[0]; i--)
        {
            if (Array.IndexOf(numbers, i) > -1)
            {
                int binarySearchResult = Array.BinarySearch(numbers, searchedNumber);
                if (binarySearchResult != -1)
                {
                    Console.WriteLine(i);
                    Environment.Exit(0);
                    break;
                }
            }
        }
        Console.WriteLine("No number was found.");
    }
}
