using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

class XMLWithoutTags
{
    static void GetWordsWithoutTags(List<string> words, string filePath)
    {
        StreamReader reader = new StreamReader(filePath);

        using (reader)
        {
            StringBuilder currentWord = new StringBuilder();
            int openBrackets = 0;
            string line = reader.ReadLine();

            while (line != null)
            {
                for (int i = 0; i < line.Length; i++)
                {
                    if (line[i] == '<')
                    {
                        if (currentWord.Length != 0)
                        {
                            words.Add(currentWord.ToString());
                            currentWord.Clear();
                        }
                        openBrackets++;
                    }
                    else if (line[i] == '>')
                    {
                        openBrackets--;
                    }

                    if (openBrackets == 0 && line[i] != '>')
                    {
                        currentWord.Append(line[i]);
                    }
                }

                line = reader.ReadLine();
            }
        }
    }

    static void PrintWords(List<String> words)
    {
        foreach (var word in words)
        {
            Console.WriteLine(word);
        }
    }

    static void Main()
    {
        const string filePath = "textFile.txt";
        List<string> words = new List<string>();

        GetWordsWithoutTags(words, filePath);
        PrintWords(words);
    }
}
