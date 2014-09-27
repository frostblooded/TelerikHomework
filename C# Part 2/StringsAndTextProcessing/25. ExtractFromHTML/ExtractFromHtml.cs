using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

class ExtractFromHTML
{
    static string GetInput()
    {
        Console.WriteLine("Enter HTML");
        string line = Console.ReadLine();
        StringBuilder result = new StringBuilder();

        while (true)
        {
            result.Append(line);

            if (line.Contains("</html>"))
            {
                break;
            }

            line = Console.ReadLine();
        }

        return result.ToString();
    }

    static void Print(string title, string bodyContents)
    {
        Console.WriteLine("Title: {0}", title);
        Console.WriteLine("Body Contents: {0}", bodyContents);
    }

    static string GetTitle(string text)
    {
        StringBuilder result = new StringBuilder();
        string titleTag = "<title>";
        Match match = Regex.Match(text, titleTag);

        for (int i = match.Index + titleTag.Length; text[i] != '<'; i++)
        {
            result.Append(text[i]);
        }

        return result.ToString();
    }

    static string GetBodyContents(string text)
    {
        StringBuilder result = new StringBuilder();
        bool openTag = false;
        bool inBody = false;

        for (int i = 0; i < text.Length; i++)
        {
            char currentChar = text[i];

            if (i < text.Length - 6 && !inBody && text.Substring(i, 6) == "<body>")
            {
                inBody = true;
                i += 5;
                continue;
            }

            if (currentChar == '<')
            {
                openTag = true;

                if (result.Length > 0)
                {
                    result.Append(' ');
                }
            }
            else if (currentChar == '>')
            {
                openTag = false;
            }
            else if(inBody && !openTag)
            {
                result.Append(currentChar);
            }
        }

        return result.ToString();
    }

    static void Main()
    {
        string text = GetInput();
        string title = GetTitle(text);
        string bodyContents = GetBodyContents(text);
        Print(title, bodyContents);
    }
}