using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class SentencesWithWord
{
    static List<string> GetSentences(string text)
    {
        List<string> sentences = new List<string>();
        string sentencePattern = @"(\S.+?\.)";
        MatchCollection matches = Regex.Matches(text, sentencePattern);

        for (int i = 0; i < matches.Count; i++)
        {
            sentences.Add(matches[i].Value);
        }

        return sentences;
    }

    static void Main()
    {
        Console.WriteLine("Input the text.");
        string input = Console.ReadLine();
        Console.WriteLine("Which is the word that we want to be in the sentences?");
        string word = Console.ReadLine();
        List<string> sentences = GetSentences(input);

        foreach (var sentence in sentences)
        {
            if (Regex.IsMatch(sentence, @"\b" + word + @"\b"))
            {
                Console.WriteLine(sentence);
            }
        }
    }
}
