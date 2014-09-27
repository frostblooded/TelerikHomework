using System;

class IsLeap
{
    static void Main()
    {
        Console.WriteLine("Which is the year that you want to check");
        Console.WriteLine(DateTime.IsLeapYear(int.Parse(Console.ReadLine())));
    }
}

