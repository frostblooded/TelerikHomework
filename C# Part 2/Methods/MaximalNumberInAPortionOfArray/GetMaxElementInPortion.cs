using System;

class GetMaxElementInPortion
{
    static int MaxNumberInPortion(int startingIndex, int[] numbers)
    {
        int maxNumber = int.MinValue;
        for (int i = startingIndex; i < numbers.Length; i++)
        {
            if (numbers[i] > maxNumber)
            {
                maxNumber = numbers[i];
            }
        }
        return maxNumber;
    }

    static void Main()
    {
        //Input
        Console.WriteLine("What is the length of the array?");
        int[] numbers = new int[int.Parse(Console.ReadLine())];
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write("numbers[{0}] = ", i);
            numbers[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Starting position?");
        int startingPosition = int.Parse(Console.ReadLine());

        //Output
        Console.WriteLine();
        Console.WriteLine("The biggest number in that portion of the array is {0}", MaxNumberInPortion(startingPosition, numbers));
    }
}
