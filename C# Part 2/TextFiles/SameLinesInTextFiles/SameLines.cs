using System;
using System.IO;

class SameLines
{
    static void Main()
    {
        string firstPath = "firstTextFile.txt";
        string secondPath = "secondTextFile.txt";
        int sameLines = 0;
        int differentLines = 0;

        using (StreamReader firstReader = new StreamReader(firstPath))
        {
            using (StreamReader secondReader = new StreamReader(secondPath))
            {
                string firstLine = firstReader.ReadLine();
                string secondLine = secondReader.ReadLine();

                while (firstLine != null)
                {
                    if (firstLine == secondLine)
                    {
                        sameLines++;
                    }
                    else
                    {
                        differentLines++;
                    }

                    firstLine = firstReader.ReadLine();
                    secondLine = secondReader.ReadLine();
                }
            }
        }

        Console.WriteLine("Same Lines: {0}", sameLines);
        Console.WriteLine("Different Lines: {0}", differentLines);
    }
}
