using System;
using System.Text.RegularExpressions;

class CountOccurrences
{
    static void Main()
    {
        string text = Console.ReadLine().ToLower();
        string searchedSubstring = Console.ReadLine().ToLower();

        Console.WriteLine(Regex.Matches(text, searchedSubstring).Count);
    }
}
