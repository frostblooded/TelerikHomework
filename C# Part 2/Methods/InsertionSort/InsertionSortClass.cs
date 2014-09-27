using System;

class InsertionSortClass
{
    static int MaxNumberInPortionIndex(int startingIndex, int[] numbers)
    {
        int maxNumber = int.MinValue;
        int maxNumberIndex = startingIndex;
        for (int i = startingIndex; i < numbers.Length; i++)
        {
            if (numbers[i] > maxNumber)
            {
                maxNumber = numbers[i];
                maxNumberIndex = i;
            }
        }
        return maxNumberIndex;
    }

    static void InsertionSort(int[] numbers)
    {
        for (int i = 0; i < numbers.Length; i++)
        {
            int swapNumberIndex = MaxNumberInPortionIndex(i, numbers);

            //Swap
            int supportingVariable = numbers[swapNumberIndex];
            numbers[swapNumberIndex] = numbers[i];
            numbers[i] = supportingVariable;
        }
    }

    static void Main()
    {
        //Input
        int[] numbers = new int[10] { 5, 23, 2, 67, 8, 19, 65, 3, 99, 7 };

        //Sort
        InsertionSort(numbers);

        //Output
        Console.WriteLine();
        foreach (var number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}
