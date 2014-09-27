using System;

class Program
{
    static int GetMax(int firstNumber, int secondNumber)
    {
        if (firstNumber > secondNumber)
        {
            return firstNumber;
        }
        else
        {
            return secondNumber;
        }
    }

    static int Solve(int firstNumber, int secondNumber, int thirdNumber)
    {
        return GetMax(GetMax(firstNumber, secondNumber), thirdNumber);
    }

    static void Main()
    {
        //Input
        Console.WriteLine("Write 3 numbers sepperated by an Enter each.");
        int firstNumber = int.Parse(Console.ReadLine());
        int secondNumber = int.Parse(Console.ReadLine());
        int thirdNumber = int.Parse(Console.ReadLine());

        Console.WriteLine();
        Console.WriteLine(Solve(firstNumber, secondNumber, thirdNumber));
    }
}
