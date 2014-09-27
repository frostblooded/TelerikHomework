using System;
using System.Collections.Generic;
using System.IO;

class RemoveOdd
{
    static void GetOddLines(List<string> lines, string filePath)
    {
        StreamReader reader = new StreamReader(filePath);

        using (reader)
        {
            string line = reader.ReadLine();

            for (int i = 1; line != null; i++)
            {
                if (i % 2 == 1)
                {
                    lines.Add(line);
                }

                line = reader.ReadLine();
            }
        }
    }

    static void PrintLines(List<string> lines, string filePath)
    {
        StreamWriter writer = new StreamWriter(filePath);

        using (writer)
        {
            foreach (var line in lines)
            {
                writer.WriteLine(line);
            }
        }
    }

    static void Main()
    {
        const string filePath = "textFile.txt";
        List<string> lines = new List<string>();

        GetOddLines(lines, filePath);
        PrintLines(lines, filePath);
    }
}