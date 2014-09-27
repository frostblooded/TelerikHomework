using System;
using System.IO;

class PrintOdd
{
    static void Main()
    {
        string filePath = @"textFile.txt";
        StreamReader reader = new StreamReader(filePath);
  
        using (reader)
        {
            string line = " ";
            for (int i = 1; line != null; i++)
            {
                line = reader.ReadLine();
                if (i % 2 == 1)
                {
                    Console.WriteLine(line);
                }
            }
        }
    }
}
