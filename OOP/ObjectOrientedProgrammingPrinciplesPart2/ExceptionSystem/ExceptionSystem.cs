using System;

namespace ExceptionSystem
{
    class ExceptionSystem
    {
        static void Main()
        {
            Console.WriteLine("Enter 5 numbers");

            for (int i = 0; i < 5; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (number < 1 || number > 100)
                {
                    throw new InvalidRangeException<int>("The number wasn't in the valid range!", new Exception(), 1, 100);
                }
            }

            Console.WriteLine("Enter a date!");

            DateTime dateTime = DateTime.Parse(Console.ReadLine());

            if (dateTime < new DateTime(1980, 1, 1) || dateTime > new DateTime(2013, 12, 31))
            {
                throw new InvalidRangeException<DateTime>("The date wasn't in the valid format!", new Exception(), new DateTime(1980, 1, 1), new DateTime(2013, 12, 31));
            }
        }
    }
}
