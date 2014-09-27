using System;

class Program
{
    static string ReturnDigitAsWord(char digit)
    {
        switch (digit)
        {
            case '0':
                return "zero";
            case '1':
                return "one";
            case '2':
                return "two";
            case '3':
                return "three";
            case '4':
                return "four";
            case '5':
                return "five";
            case '6':
                return "six";
            case '7':
                return "seven";
            case '8':
                return "eight";
            case '9':
                return "nine";
            default:
                return "Something is wrong";
        }
    }

    static string GiveLastDigitAsWord(string number)
    {
        return ReturnDigitAsWord(number[number.Length - 1]);
    }

    static void Main()
    {
        //Input
        Console.WriteLine("Input a number.");
        string number = Console.ReadLine();

        //Output
        Console.WriteLine(GiveLastDigitAsWord(number));
    }
}
