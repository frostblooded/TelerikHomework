using System;

class Program
{
    static void Main(string[] args)
    {
        for (int i = 0; i < 256; i++)
        {
            Console.WriteLine((char)i + " " + i);
            if (i % 20 == 0)
            {
                Console.ReadLine();
            }
        }
    }
}
