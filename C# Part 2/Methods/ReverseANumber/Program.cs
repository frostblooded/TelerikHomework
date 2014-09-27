using System;

class Program
{
    static int ReverseNumber(int number)
    {
        string numberAsString = number.ToString();
        string resultString = null;
        for (int i = numberAsString.Length - 1; i >= 0; i--)
        {
            resultString += numberAsString[i];
        }
        return int.Parse(resultString);
    }

    static void Main()
    {
        //Input
        Console.WriteLine("Input a number to be reversed.");
        int number = int.Parse(Console.ReadLine());

        //Output
        Console.WriteLine(ReverseNumber(number));
    }
}
