using System;

class Square
{
    static double Sqrt(double number)
    {
        if (number < 0)
        {
            throw new ArgumentException("Number must be equal to or above zero.");
        }

        return Math.Sqrt(number);
    }

    static void Main()
    {
        try
        {
            Console.WriteLine("Input a number.");
            double input = int.Parse(Console.ReadLine());
            double result = Sqrt(input);
            Console.WriteLine(result);
        }
        catch (ArgumentException ex)
        {
            Console.Error.WriteLine(ex.Message);
        }
    }
}
