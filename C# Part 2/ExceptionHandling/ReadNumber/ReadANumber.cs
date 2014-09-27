using System;

class ReadANumber
{
    static int ReadNumber(int start, int end)
    {
        int number = int.Parse(Console.ReadLine());

        if (number < start || number > end)
        {
            throw new ArgumentException();
        }

        return number;
    }

    static void Main()
    {
        Console.WriteLine("What is the minimal input number?");
        int start = int.Parse(Console.ReadLine());
        Console.WriteLine("What is the maximal input number?");
        int end = int.Parse(Console.ReadLine());

        for (int i = 0; i < 10; i++)
        {
            try
            {
                Console.WriteLine("Input number {0}", i + 1);
                int number = ReadNumber(start, end);
            }
            catch (Exception ex)
            {
                if (ex is ArgumentException)
                {
                    Console.WriteLine("The input number wasn't in the alowed range. Please try again.");
                }
                else if (ex is FormatException)
                {
                    Console.WriteLine("The input isn't an integer number. Please try again.");
                }
                else
                {
                    Console.WriteLine("An unknown error occured. Please try again.");
                }

                i--;
            }
        }
    }
}
