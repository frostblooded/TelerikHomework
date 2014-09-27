using System;

class Program
{
    static void QuickSort(IComparable[] usedNumbers, int left, int right)
    {
        if (right - left < 1)
        {
            return;
        }
        IComparable pivot = usedNumbers[(left + right) / 2];

        int firstSelector = left, secondSelector = right;
        while (firstSelector <= secondSelector)
        {
            while (usedNumbers[firstSelector].CompareTo(pivot) < 0)
            {
                firstSelector++;
            }
            while (usedNumbers[secondSelector].CompareTo(pivot) > 0)
            {
                secondSelector--;
            }
            if (usedNumbers[firstSelector] == usedNumbers[secondSelector])
            {
                firstSelector++;
                continue;
            }

            if (firstSelector <= secondSelector)
            {
                //Swap
                IComparable supportingVariable = usedNumbers[firstSelector];
                usedNumbers[firstSelector] = usedNumbers[secondSelector];
                usedNumbers[secondSelector] = supportingVariable;

                firstSelector++;
                secondSelector--;
            }
        }

        //Recursion
        QuickSort(usedNumbers, left, secondSelector); //Sort Left Part
        QuickSort(usedNumbers, firstSelector, right); //Sort Right Part 
    }

    static void Main()
    {
        IComparable[] numbers = new IComparable[10] { 30, 11, 59, 89, 63, 97, 23, 16, 48, 79 };
        QuickSort(numbers, 0, numbers.Length - 1);

        Console.WriteLine();
        foreach (var number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}
