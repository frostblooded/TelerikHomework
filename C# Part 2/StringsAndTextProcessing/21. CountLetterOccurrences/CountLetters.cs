using System;
using System.Collections.Generic;

class Letter
{
    public char Character { get; set; }
    public int Occurrences { get; set; }

    public Letter(char character, int startingOccurrences = 1)
    {
        Character = character;
        Occurrences = startingOccurrences;
    }
}

class CountLetters
{
    static List<Letter> letters = new List<Letter>();

    static string GetInput()
    {
        Console.WriteLine("Enter text.");
        return Console.ReadLine();
    }

    static void CreateCharOrIncreaseOccurrences(char character)
    {
        foreach (var letter in letters)
        {
            if (letter.Character == character)
            {
                letter.Occurrences++;
                return;
            }
        }

        letters.Add(new Letter(character));
    }

    static void CountOccurrences(string text)
    {
        for (int i = 0; i < text.Length; i++)
        {
            if (Char.IsLetter(text[i]))
            {
                CreateCharOrIncreaseOccurrences(text[i]);
            }
        }
    }

    static void PrintLetters()
    {
        foreach (var letter in letters)
        {
            Console.WriteLine("\"{0}\" occurs {1} times in the text", letter.Character, letter.Occurrences);
        }
    }

    static void Main()
    {
        string text = GetInput();
        CountOccurrences(text);
        PrintLetters();
    }
}
