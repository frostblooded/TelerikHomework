using System;

class Program
{
    static void Main(string[] args)
    {
        string hello = "Hello", world = "World";
        object resultObject= hello + " " + world;
        string resultString = (string)resultObject;
        Console.WriteLine(resultString);
    }
}
