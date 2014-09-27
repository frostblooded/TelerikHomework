using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        //Input
        string[] strings = new string[10] { "Cat", "Newbie", "Solomon", "Rice", "Garfield", "Mouse", "PewDiePie", "Thanks", "Bye", "Goodbye" };

        //Sort
        Array.Sort(strings, (string x, string y) => x.Length.CompareTo(y.Length));

        Console.WriteLine();
        foreach (var word in strings)
        {
            Console.WriteLine(word);
        }
    }
}
