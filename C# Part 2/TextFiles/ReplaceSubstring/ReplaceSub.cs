using System;
using System.IO;

class ReplaceSub
{
    static void Main()
    {
        const string replacedSubstring = "start";
        const string newSubstring = "finish";
        string inputPath = "textFile.txt";
        string outputPath = "result.txt";

        StreamWriter writer = new StreamWriter(outputPath);
        StreamReader reader = new StreamReader(inputPath);

        using (writer)
        {
            using (reader)
            {
                string line = reader.ReadLine();

                while (line != null)
                {
                    writer.WriteLine(line.Replace(replacedSubstring, newSubstring));
                    line = reader.ReadLine();
                }
            }
        }
    }
}

