using System;

class DatesFormatting
{
    static DateTime GetDate()
    {
        string[] firstDateAsStrings = Console.ReadLine().Split('.');
        int[] firstDate = new int[firstDateAsStrings.Length];

        for (int i = 0; i < firstDateAsStrings.Length; i++)
        {
            firstDate[i] = int.Parse(firstDateAsStrings[i]);
        }

        return new DateTime(firstDate[2], firstDate[1], firstDate[0]);
    }

    static void Main()
    {
        Console.Write("Enter the first date: ");
        DateTime firstDate = GetDate();
        Console.Write("Enter the second date: ");
        DateTime secondDate = GetDate();
        Console.WriteLine("Distance: {0} days", (secondDate - firstDate).TotalDays);
    }
}

