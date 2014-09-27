using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

class ReplaceWord
{
    static void Main()
    {
        const string replacedWord = "start";
        const string newWord = "finish";
        const string inputPath = "textFile.txt";
        const string outputPath = "result.txt";

        StreamWriter writer = new StreamWriter(outputPath);
        StreamReader reader = new StreamReader(inputPath);

        using (writer)
        {
            using (reader)
            {
                string line = reader.ReadLine();

                while (line != null)
                {
                    writer.WriteLine(Regex.Replace(line, @"\b" + replacedWord + @"\b", newWord));
                    line = reader.ReadLine();
                }
            }
        }
    }
}

