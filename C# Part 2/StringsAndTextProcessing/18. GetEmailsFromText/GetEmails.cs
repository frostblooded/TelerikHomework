using System;
using System.Text.RegularExpressions;

class GetEmails
{
    static string GetInput()
    {
        Console.WriteLine("Enter text.");
        return Console.ReadLine();
    }

    static MatchCollection GetMacthes(string text)
    {
        string pattern = @"\b[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}\b";
        return Regex.Matches(text, pattern);
    }

    static void PrintMacthes(MatchCollection emails)
    {
        for (int i = 0; i < emails.Count; i++)
        {
            Console.WriteLine(emails[i].Value);
        }
    }

    static void Main()
    {
        string text = GetInput();
        MatchCollection emails = GetMacthes(text);
        PrintMacthes(emails);
    }
}