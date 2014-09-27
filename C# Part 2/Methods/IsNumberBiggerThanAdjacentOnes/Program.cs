using System;

class Program
{
    static bool IsNumberBiggerThanAdjacentOnes(int numberPosition, int[] array)
    {
        bool? biggerThanLeft = false, biggerThanRight = false;
        if (numberPosition != 0)
        {
            if (array[numberPosition] > array[numberPosition - 1])
            {
                biggerThanLeft = true;
            }
        }
        else
        {
            biggerThanLeft = null;
        }

        if (numberPosition != array.Length - 1)
        {
            if (array[numberPosition] > array[numberPosition + 1])
            {
                biggerThanRight = true;
            }
        }
        else
        {
            biggerThanRight = null;
        }

        if (biggerThanLeft != false && biggerThanRight != false)
        {
            return true;
        }
        return false;
    }

    static void Main()
    {
        //Input
        Console.WriteLine("What is the length of the array?");
        int[] numbers = new int[int.Parse(Console.ReadLine())];
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine("numbers[{0}] = ", i);
            numbers[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("At which position is the checked number?");
        int searchedNumberPosition = int.Parse(Console.ReadLine());

        //Output
        Console.WriteLine(IsNumberBiggerThanAdjacentOnes(searchedNumberPosition, numbers));
    }
}
