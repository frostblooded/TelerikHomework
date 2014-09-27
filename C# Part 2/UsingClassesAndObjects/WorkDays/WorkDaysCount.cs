using System;

class WorkDaysCount
{
    static void FillHolidays(DateTime[] holidays)
    {
        holidays[0] = new DateTime(2013, 1, 1);
        holidays[1] = new DateTime(2013, 3, 3);
        holidays[2] = new DateTime(2013, 5, 3);
        holidays[3] = new DateTime(2013, 5, 4);
        holidays[4] = new DateTime(2013, 5, 5);
        holidays[5] = new DateTime(2013, 5, 6);
        holidays[6] = new DateTime(2013, 5, 1);
        holidays[8] = new DateTime(2013, 5, 24);
        holidays[9] = new DateTime(2013, 9, 6);
        holidays[10] = new DateTime(2013, 9, 22);
        holidays[11] = new DateTime(2013, 11, 1);
        holidays[12] = new DateTime(2013, 12, 24);
        holidays[13] = new DateTime(2013, 12, 25);
        holidays[13] = new DateTime(2013, 12, 26);
    }

    static void Main()
    {
        //Input
        Console.WriteLine("Which is the date? Input year, month, day seperated by an Enter.");
        DateTime date = new DateTime(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));

        //Make holidays array
        DateTime[] holidays = new DateTime[14];
        FillHolidays(holidays);

        //Calculate
        int dayCount = 0;
        DateTime currentDay = DateTime.Today;
        while (currentDay != date)
        {
            if (Array.IndexOf(holidays, currentDay) == -1 && currentDay.DayOfWeek != DayOfWeek.Saturday && currentDay.DayOfWeek != DayOfWeek.Sunday)
            {
                dayCount++;
            }
            currentDay = currentDay.AddDays(1);
        }
        
        //Output
        Console.WriteLine(dayCount);
    }
}