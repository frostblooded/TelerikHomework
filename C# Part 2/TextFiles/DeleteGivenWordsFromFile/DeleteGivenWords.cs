using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

class DeleteGivenWords
{
    static List<string> lines = new List<string>();
    static List<string> words = new List<string>();
    static string wordsPath = "words.txt";
    static string textPath = "text.txt";

    static void GetLines()
    {
        try
        {
            StreamReader reader = new StreamReader(textPath);

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
        catch(FileNotFoundException)
        {
            Console.WriteLine("The file {0} could not be found!", textPath);
        }
        catch (IOException)
        {
            Console.WriteLine("An I/O exception occured and the file {0} couldn't be opened.", textPath);
        }
    }

    static void GetWords()
    {
        try
        {
            StreamReader reader = new StreamReader(wordsPath);

            using (reader)
            {
                string word = reader.ReadLine();

                while (word != null)
                {
                    words.Add(word);
                    word = reader.ReadLine();
                }
            }
        }
        catch(FileNotFoundException)
        {
            Console.WriteLine("The file {0} could not be found!", wordsPath);
        }
        catch(IOException)
        {
            Console.WriteLine("An I/O exception occured and the file {0} couldn't be opened.", wordsPath);
        }
    }

    static void DeleteWords()
    {
        for (int i = 0; i < lines.Count; i++)
        {
            for (int j = 0; j < words.Count; j++)
            {
                if (lines[i].Contains(words[j]))
                {
                    lines[i] = Regex.Replace(lines[i], @"\b" + words[j] + @"\b\s?", String.Empty);
                }
            }
        }
    }

    static void WriteLines()
    {
        try
        {
            StreamWriter writer = new StreamWriter(textPath);

            using (writer)
            {
                foreach (var line in lines)
                {
                    writer.WriteLine(line);
                }
            }
        }
        catch(UnauthorizedAccessException)
        {
            Console.WriteLine("The file {0} could not be accessed", textPath);
        }
    }

    static void Main()
    {
        GetLines();
        GetWords();
        DeleteWords();
        WriteLines();
    }
}
