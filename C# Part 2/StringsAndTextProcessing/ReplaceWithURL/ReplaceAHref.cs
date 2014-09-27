using System;
using System.Text;

class ReplaceAHref
{
    static string Replace(string text)
    {
        bool openBracket = false;
        bool openTag = false;
        StringBuilder result = new StringBuilder();

        for (int i = 0; i < text.Length; i++)
        {

            if (!openTag && i < text.Length - 7 && text.Substring(i, 7) == "<a href")
            {
                openBracket = true;
                openTag = true;
                result.Append("[URL");
                i += 6;
                continue;
            }

            if (text[i] == '"' && openBracket)
            {
                continue;
            }

            if (text[i] == '>' && openBracket)
            {
                result.Append(']');
                openBracket = false;
                continue;
            }

            if (i < text.Length - 4 && openTag && text.Substring(i, 4) == "</a>")
            {
                result.Append("[/URL]");
                openTag = false;
                i += 3;
                continue;
            }

            result.Append(text[i]);
        }

        return result.ToString();
    }

    static void Main()
    {
        string input = Console.ReadLine();
        string result = Replace(input);
        Console.WriteLine(result);
    }
}