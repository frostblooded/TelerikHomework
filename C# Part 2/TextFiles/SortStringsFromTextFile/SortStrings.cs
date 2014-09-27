using System;
using System.Collections.Generic;
using System.IO;

class SortStrings
{
    static void Main()
    {
        string inputPath = "textFile.txt";
        string outputPath = "result.txt";
        StreamWriter writer = new StreamWriter(outputPath);
        string[] strings = File.ReadAllLines(inputPath);

        Array.Sort(strings);

        using (writer)
        {
            foreach (var line in strings)
            {
                writer.WriteLine(line);
            }
        }
    }
}
