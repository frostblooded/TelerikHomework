using System;
using System.Globalization;
using System.Threading;

class Add6Min
{
    static DateTime ReadDateTime()
    {
        Console.WriteLine("Enter the date.");
        string[] dateAsString = Console.ReadLine().Split('.');
        Console.WriteLine("Enter the time.");
        string[] timeAsString = Console.ReadLine().Split(':');

        int[] date = new int[dateAsString.Length];
        int[] time = new int[timeAsString.Length];

        for (int i = 0; i < dateAsString.Length; i++)
        {
            date[i] = int.Parse(dateAsString[i]);
        }

        for (int i = 0; i < timeAsString.Length; i++)
        {
            time[i] = int.Parse(timeAsString[i]);
        }

        return new DateTime(date[2], date[1], date[0], time[0], time[1], time[2]);
    }

    static DateTime AdvanceTime(DateTime dateAndTime)
    {
        dateAndTime = dateAndTime.AddHours(6);
        dateAndTime = dateAndTime.AddMinutes(30);
        return dateAndTime;
    }

    static string GetFormat(DateTime dateAndTime)
    {
        string dayOfWeek = Thread.CurrentThread.CurrentCulture.DateTimeFormat.GetDayName(dateAndTime.DayOfWeek);
        return String.Format("{0:dd.MM.yyyy HH:mm:ss} {1}", dateAndTime, dayOfWeek);
    }

    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = new CultureInfo("bg-BG");
        DateTime dateAndTime = ReadDateTime();
        dateAndTime = AdvanceTime(dateAndTime);
        Console.WriteLine(GetFormat(dateAndTime));
    }
}