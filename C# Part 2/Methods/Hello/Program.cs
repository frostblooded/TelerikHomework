using System;

class Program
{
    private static void Hello(string name)
    {
        Console.WriteLine("Hello, {0}", name);
    }

    static void Main()
    {
        Console.WriteLine("What is your name?");
        string name = Console.ReadLine();
        Hello(name);
    }
}