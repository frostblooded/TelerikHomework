using System;

class Program
{
    static void Main(string[] args)
    {
        int? a = null;
        double? b = null;
        Console.WriteLine(a + " " + b);
        a = 2;
        b = 3;
        Console.WriteLine(a + " " + b);
    }
}
