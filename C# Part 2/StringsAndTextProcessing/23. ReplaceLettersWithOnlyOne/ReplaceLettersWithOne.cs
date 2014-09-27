using System;
using System.Text;

class ReplaceLettersWithOne
{
    static string GetInput()
    {
        Console.WriteLine("Enter the text");
        return Console.ReadLine();
    }

    static string ReplaceLetters(string text)
    {
        StringBuilder result = new StringBuilder();
        char lastLetter = '0'; //The initialization doesn't matter

        for (int i = 0; i < text.Length; i++)
        {
            if (i != 0 && text[i] != lastLetter)
            {
                result.Append(text[i]);
                lastLetter = text[i];
            }
        }

        return result.ToString();
    }

    static void Main()
    {
        string text = GetInput();
        string result = ReplaceLetters(text);
        Console.WriteLine(result);
    }
}
