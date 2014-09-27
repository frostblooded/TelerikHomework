using System;

class Reverse
{
    static void Main()
    {
        string input = Console.ReadLine();
        char[] inputAsCharArray = input.ToCharArray();
        Array.Reverse(inputAsCharArray);
        Console.WriteLine(inputAsCharArray);
    }
}
