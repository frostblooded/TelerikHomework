using System;

class PrintNumber
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("Decimal Representation: {0,15}", number);
        Console.WriteLine("Hexadecimal Representation: {0,15}", number.ToString("X"));
        Console.WriteLine("Percentage Representation: {0,15}", number.ToString("P"));
        Console.WriteLine("PScientific Notation: {0,15}", number.ToString("E"));
    }
}