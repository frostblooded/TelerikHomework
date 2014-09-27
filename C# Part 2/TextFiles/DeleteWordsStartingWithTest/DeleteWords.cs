using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

class DeleteWords
{
    static string patternToDelete = @"\btest[a-zA-Z0-9_]*\b\s?";
    static string filePath = "textFile.txt";
    static List<string> lines = new List<string>();

    static void GetLines()
    {
        StreamReader reader = new StreamReader(filePath);

        using (reader)
        {
            string line = reader.ReadLine();

            while (line != null)
            {
                lines.Add(line);
                line = reader.ReadLine();
            }
        }
    }

    static void Delete()
    {
        for (int i = 0; i < lines.Count; i++)
        {
            lines[i] = Regex.Replace(lines[i], patternToDelete, String.Empty);
        }
    }

    static void WriteLines()
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
        GetLines();
        Delete();
        WriteLines();
    }
}
