using System;

class Program
{
    static bool IsNumberBiggerThanAdjacentOnes(int numberPosition, int[] numbers)
    {
        if (numbers.Length < 2)
        {
            return false;
        }

        bool? biggerThanLeft = false, biggerThanRight = false;
        if (numberPosition != 0)
        {
            if (numbers[numberPosition] > numbers[numberPosition - 1])
            {
                biggerThanLeft = true;
            }
        }
        else
        {
            biggerThanLeft = null;
        }

        if (numberPosition != numbers.Length - 1)
        {
            if (numbers[numberPosition] > numbers[numberPosition + 1])
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

    static int FirstElementBiggerThanAdjacent(int[] numbers)
    {
        for (int i = 0; i < numbers.Length; i++)
        {
            if (IsNumberBiggerThanAdjacentOnes(i, numbers))
            {
                return i;
            }
        }
        return -1;
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

        //Solution
        int indexOfNumber = FirstElementBiggerThanAdjacent(numbers);

        //Output
        if (indexOfNumber != -1)
        {
            Console.WriteLine("The first number bigger than its adjacent ones is {0} at position {1}.", numbers[indexOfNumber], indexOfNumber);
        }
        else
        {
            Console.WriteLine("There is no number that is bigger than its adjacent ones.");
        }
    }
}
