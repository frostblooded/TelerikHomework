using System;
using System.Collections.Generic;

class ReverseWordsInSentence
{
    static void Main()
    {
        Console.WriteLine("Input the sentence.");
        string[] words = Console.ReadLine().Split(' ');
        List<string> punctuation = new List<string>() { ".", ",", "!", "?" };
        string[] punctuationPositions = new string[words.Length]; 

        for (int i = 0; i < words.Length; i++)
        {
            foreach (var item in punctuation) //This cycle gets the positions of the punctuation and removes it
            {
                if (words[i].Contains(item))
                {
                    punctuationPositions[i] = item;
                    words[i] = words[i].Remove(words[i].Length - 1);
                }
            }
        }

        int j = 0;
        for (int i = words.Length - 1; i >= 0; i--, j++)
        {
            Console.Write("{0}", words[i]);

            if (punctuationPositions[i] != String.Empty)
            {
                Console.Write(punctuationPositions[j]);
            }

            Console.Write(" ");
        }
    }
}