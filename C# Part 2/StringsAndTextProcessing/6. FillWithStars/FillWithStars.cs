using System;
using System.Text;

class FillWithStars
{
    static string GetInput()
    {
        Console.WriteLine("Input text that is smaller than 20 characters.");
        string input = Console.ReadLine();

        if (input.Length > 20)
        {
            throw new FormatException();
        }

        return input;
    }

    static string FillString(string input)
    {
        StringBuilder text = new StringBuilder(input);

        for (int i = 0; i < 20 - input.Length; i++)
        {
            text.Append('*');
        }

        return text.ToString();
    }

    static void Main()
    {
        try
        {
            string input = GetInput();
            input = FillString(input);
            Console.WriteLine(input);
        }
        catch (FormatException)
        {
            Console.WriteLine("The text should be smaller than 20 characters!");
        }
    }
}
