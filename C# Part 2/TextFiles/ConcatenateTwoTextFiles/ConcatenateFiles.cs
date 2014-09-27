using System;
using System.IO;
using System.Text;

class ConcatenateFiles
{
    static void Main()
    {
        string firstFilePath = @"firstTextFile.txt";
        string secondFilePath = @"secondTextFile.txt";
        string resultFilePath = @"resultTextFile.txt";
        StreamReader firstReader = new StreamReader(firstFilePath);
        StreamReader secondReader = new StreamReader(secondFilePath);
        StreamWriter resultWriter = new StreamWriter(resultFilePath);
        string firstFileContents;
        string secondFileContents;

        using (firstReader)
        {
            firstFileContents = firstReader.ReadToEnd();
        }

        using (secondReader)
        {
            secondFileContents = secondReader.ReadToEnd();
        }

        StringBuilder resultString = new StringBuilder();
        resultString.Append(firstFileContents);
        resultString.Append(Environment.NewLine);
        resultString.Append(secondFileContents);

        using (resultWriter)
        {
            resultWriter.WriteLine(resultString);   
        }
    }
}
