using System;
using System.Text;

class ToUnicode
{
    static string GetEscapeSequence(char c)
    {
        return "\\u" + ((int)c).ToString("X4");
    }

    static void Main()
    {
        Console.WriteLine("Input the text");
        string text = Console.ReadLine();
        StringBuilder result = new StringBuilder();

        for (int i = 0; i < text.Length; i++)
        {
            result.Append(GetEscapeSequence(text[i]));
        }

        Console.WriteLine(result);
    }
}

