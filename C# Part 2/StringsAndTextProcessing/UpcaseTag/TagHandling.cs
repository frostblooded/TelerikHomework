using System;
using System.Text.RegularExpressions;

class TagHandling
{
    static string GetWord(string wholeInput)
    {
        int firstUpcaseEnd = wholeInput.IndexOf('>');
        int secondUpcaseStart = wholeInput.LastIndexOf('<');
        return wholeInput.Substring(firstUpcaseEnd + 1, secondUpcaseStart - firstUpcaseEnd - 1);
    }

    static void Main()
    {
        string input = Console.ReadLine();
        MatchCollection matches = Regex.Matches(input, @"<upcase>[a-zA-Z\s]*</upcase>");

        for (int i = 0; i < matches.Count; i++)
        {
            string word = GetWord(matches[i].Value);
            input = input.Replace(matches[i].Value, word.ToUpper());
        }

        Console.WriteLine(input);
    }
}