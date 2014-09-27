using System;

class SortListOfWords
{
    static string[] GetWords()
    {
        Console.WriteLine("Enter the words seperated by a space");
        return Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
    }

    static void PrintWords(string[] words)
    {
        foreach (var word in words)
        {
            Console.WriteLine(word);
        }
    }

    static void Main()
    {
        string[] words = GetWords();
        Array.Sort(words);
        PrintWords(words);
    }
}