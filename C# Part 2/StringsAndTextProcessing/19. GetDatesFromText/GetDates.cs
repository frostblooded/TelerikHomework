using System;
using System.Globalization;
using System.Text.RegularExpressions;

class GetDates
{
    static string GetInput()
    {
        Console.WriteLine("Enter text");
        return Console.ReadLine();
    }

    static MatchCollection GetDatesFromText(string text)
    {
        string pattern = @"\b[0-9]{2}\.[0-9]{2}\.[0-9]{4}\b";
        return Regex.Matches(text, pattern);
    }

    static void PrintDates(MatchCollection dates)
    {
        for (int i = 0; i < dates.Count; i++)
        {
            DateTime dateTime = Convert.ToDateTime(dates[i].Value);
            string onlyDate = dateTime.Date.ToString("d"); //Get only the date
            Console.WriteLine(onlyDate.ToString(new CultureInfo("en-CA"))); //Prints in Canadian culture
        }
    }

    static void Main()
    {
        string text = GetInput();
        MatchCollection dates = GetDatesFromText(text);
        PrintDates(dates);
    }
}