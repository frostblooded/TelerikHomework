using System;

class Program
{
    static void Main(string[] args)
    {
        int a = 5, b = 10, numberHolder;
        numberHolder = a;
        a = b;
        b = numberHolder;
        Console.WriteLine(a + " " + b);
    }
}
