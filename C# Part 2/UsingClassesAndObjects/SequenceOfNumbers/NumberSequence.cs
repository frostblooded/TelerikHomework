using System;
using System.Text;

class NumberSequence
{
    static void Main()
    {
        Console.WriteLine("Input numbers divided by space.");
        string inputString = Console.ReadLine();
        string[] numbers = inputString.Split(' ');
        int result = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            result += int.Parse(numbers[i]);
        }
        Console.WriteLine("Their sum is " + result);
    }
}