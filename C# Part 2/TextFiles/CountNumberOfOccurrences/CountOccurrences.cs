using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

class Word
{
    public string Value { get; set; }

    public int Occurrences { get; set; }

    public Word(string word, int occurrences)
    {
        Value = word;
        Occurrences = occurrences;
    }
}

class CountOccurrences
{
    static List<string> lines = new List<string>();
    static List<Word> words = new List<Word>();
    static string wordsPath = "words.txt";
    static string textPath = "text.txt";
    static string outputPath = "output.txt";

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
                    lines.Add(line.ToLower());
                    line = reader.ReadLine();
                }
            }
        }
        catch (FileNotFoundException)
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
                    words.Add(new Word(word.ToLower(), 0));
                    word = reader.ReadLine();
                }
            }
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("The file {0} could not be found!", wordsPath);
        }
        catch (IOException)
        {
            Console.WriteLine("An I/O exception occured and the file {0} couldn't be opened.", wordsPath);
        }
    }

    static void Count()
    {
        foreach (var line in lines)
        {
            foreach (var word in words)
            {
                word.Occurrences += Regex.Matches(line, @"\b" + word.Value + @"\b").Count;
            }
        }
    }

    static void WriteOutput()
    {
        try
        {
            StreamWriter writer = new StreamWriter(outputPath);

            using (writer)
            {
                foreach (var word in words)
                {
                    writer.WriteLine("{0} ({1})", word.Value, word.Occurrences);
                }
            }
        }
        catch (UnauthorizedAccessException)
        {
            Console.WriteLine("The file {0} could not be accessed", outputPath);
        }
    }

    static void Main()
    {
        GetLines();
        GetWords();
        Count();
        words.Sort((Word firstWord, Word secondWord) => secondWord.Occurrences.CompareTo(firstWord.Occurrences));
        WriteOutput();
    }

}
