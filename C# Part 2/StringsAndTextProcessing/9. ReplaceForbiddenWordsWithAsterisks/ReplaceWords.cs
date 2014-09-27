using System;
using System.Collections.Generic;
using System.Text;

class ReplaceWords
{
    static string Replace(string text, List<string> forbiddenWords)
    {
        foreach (var word in forbiddenWords)
        {
            StringBuilder asterisks = new StringBuilder();

            for (int i = 0; i < word.Length; i++)
            {
                asterisks.Append('*');
            }

            text = text.Replace(word, asterisks.ToString());
        }

        return text;
    }

    static void Main()
    {
        Console.WriteLine("Input the text");
        string text = Console.ReadLine();
        Console.WriteLine("Input the forbidden words, separating them with a space.");
        string words = Console.ReadLine();
        List<string> forbiddenWords = new List<string>(words.Split(' '));
        Console.WriteLine(Replace(text, forbiddenWords));
    }
}
