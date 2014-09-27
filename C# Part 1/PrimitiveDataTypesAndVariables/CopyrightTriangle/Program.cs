using System;

class Program
{
    static void Main(string[] args)
    {
        char unicodeChar = (char)169;
        for (int i = 0; i < 3; i++)
        {
            for (int z = 0; z < 3 - i - 1; z++)
            {
                Console.Write(" ");
            }
            for (int z = 0; z < 2*i + 1; z++)
            {
                Console.Write(unicodeChar);
            }
            Console.WriteLine();
        }
    }
}
