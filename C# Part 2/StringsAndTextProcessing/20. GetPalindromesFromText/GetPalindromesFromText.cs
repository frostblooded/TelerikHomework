using System;

class GetPalindromesFromText
{
    static string GetInput()
    {
        Console.WriteLine("Enter text.");
        return Console.ReadLine();
    }

    static bool IsPalindrome(string word)
    {
        for (int i = 0; i < word.Length / 2; i++)
        {
            if (word[i] != word[word.Length - (i + 1)])
            {
                return false;
            }
        }

        return true;
    }

    static void PrintPalindromeWords(string[] words)
    {
        foreach (var word in words)
        {
            if (IsPalindrome(word))
            {
                Console.WriteLine(word);
            }
        }
    }

    static void Main()
    {
        string[] words = GetInput().Split(' ');
        PrintPalindromeWords(words);
    }
}
