using System;

class Program
{
    static int currentSelection = 0;

    static void ReverseNumber()
    {
        //Input
        int number;
        do
        {
            Console.WriteLine("Which is the number you want to be reversed? (It shouldn't be negative.)");
            number = int.Parse(Console.ReadLine());
        } while (number < 0);

        //Reverse
        string numberAsString = number.ToString(), reversedNumber = null;
        for (int i = 0; i < numberAsString.Length; i++)
        {
            reversedNumber += numberAsString[numberAsString.Length - (i + 1)];
        }

        Console.WriteLine(reversedNumber);
        Console.ReadLine();
    }

    static void AverageOfNumber()
    {
        double result = 0;
        int numbersCount;
        do
        {
            Console.WriteLine("How many numbers will you input? (The count should be more than 0)");
            numbersCount = int.Parse(Console.ReadLine());
        } while (numbersCount > 0);
        for (int i = 0; i < numbersCount; i++)
        {
            Console.WriteLine("Number {0}?", i + 1);
            result += int.Parse(Console.ReadLine());
        }
        result /= numbersCount;
        Console.WriteLine("The average of these numbers is {0:0.00}", result);
        Console.ReadLine();
    }

    static void LinearEquation()
    {
        Console.WriteLine("This solves a linear equation, which looks like this - \"a*x + b = 0\", where we are searching for \"x\"");
        float a;
        do
        {
            Console.WriteLine("What is the value of \"a\" ? (It should be more than 0)");
            a = int.Parse(Console.ReadLine());
        } while (a < 0);
        Console.WriteLine("What is the value of \"b\" ?");
        float b = int.Parse(Console.ReadLine());

        float result = -(b / a);
        Console.WriteLine("\"x\" = {0:0.00}", result);
        Console.ReadLine();
    }

    static void HandleInput(ConsoleKey inputKey)
    {
        switch (inputKey)
        {
            case ConsoleKey.UpArrow:
                if (currentSelection != 0)
                {
                    currentSelection--;
                }
                break;
            case ConsoleKey.DownArrow:
                if (currentSelection != 2)
                {
                    currentSelection++;
                }
                break;
            case ConsoleKey.Enter:
                Console.Clear();
                switch (currentSelection)
                {
                    case 0:
                        ReverseNumber();
                        break;
                    case 1:
                        AverageOfNumber();
                        break;
                    case 2:
                        LinearEquation();
                        break;
                }
                break;
        }
    }

    static void Main()
    {
        ConsoleKey inputKey;
        //Menu
        do
        {
            Console.Clear();

            //Print each member of the menu
            for (int i = 0; i < 3; i++)
            {
                if (currentSelection == i)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                switch(i)
                {
                    case 0:
                        Console.WriteLine("1. Reverse digits.");
                        break;
                    case 1:
                        Console.WriteLine("2. Average of integers.");
                        break;
                    case 2:
                        Console.WriteLine("3. Solve a linear equation.");
                        break;
                }
                Console.ForegroundColor = ConsoleColor.White;
            }

            inputKey = Console.ReadKey().Key;
            HandleInput(inputKey);
        } while (inputKey != ConsoleKey.Escape);
    }
}
