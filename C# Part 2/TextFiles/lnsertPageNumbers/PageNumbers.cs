using System;
using System.IO;

class PageNumbers
{
    static void Main()
    {
        string filePath = @"textFile.txt";
        string resultFilePath = @"resultFile.txt";
        StreamReader reader = new StreamReader(filePath);
        StreamWriter writer = new StreamWriter(resultFilePath);

        using (reader)
        {
            using (writer)
            {
                string line = reader.ReadLine();
                for (int i = 1; line != null; i++)
                {
                    writer.WriteLine("{0}. {1}", i, line);
                    line = reader.ReadLine();
                }
            }
        }
    }
}
