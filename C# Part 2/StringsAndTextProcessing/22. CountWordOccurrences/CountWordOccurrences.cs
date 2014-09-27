using System;
using System.Collections.Generic;

class Word
{
    public string Value { get; set; }

    public int Occurrences { get; set; }

    public Word(string word, int startingOccurrences = 1)
    {
        Value = word;
        Occurrences = startingOccurrences;
    }
}

class CountWordOccurrences
{
    static List<Word> words = new List<Word>();

    static string GetInput()
    {
        Console.WriteLine("Enter text");
        return Console.ReadLine();
    }

    static void CreateWordOrIncreaseOccurrences(string checkedWord)
    {
        foreach (var word in words)
        {
            if (word.Value == checkedWord)
            {
                word.Occurrences++;
                return;
            }
        }

        words.Add(new Word(checkedWord));
    }

    static void CountOccurrences(string[] inputWords)
    {
        foreach (var word in inputWords)
        {
            CreateWordOrIncreaseOccurrences(word);
        }
    }

    static void PrintWords()
    {
        foreach (var word in words)
        {
            Console.WriteLine("\"{0}\" occured {1} times in the text", word.Value, word.Occurrences);
        }
    }

    static void Main()
    {
        string[] inputWords = GetInput().Split(new char[] { ' ', ',', '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
        CountOccurrences(inputWords);
        PrintWords();
    }
}