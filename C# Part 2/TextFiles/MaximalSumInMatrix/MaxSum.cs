using System;
using System.IO;
using System.Text;

class MaxSum
{
    static void FillMatrix(StreamReader reader, int[,] matrix)
    {
        using (reader)
        {
            int Y = 0, X = 0;
            string line = reader.ReadLine();
            StringBuilder number = new StringBuilder();

            while (line != null)
            {
                X = 0;

                for (int i = 0; i < line.Length; i++)
                {
                    if (char.IsDigit(line[i]))
                    {
                        number.Append(line[i]);
                    }
                    if (!char.IsDigit(line[i]) || i == line.Length - 1) //Second part is so that it also happens at the end of each line
                    {
                        matrix[Y, X] = int.Parse(number.ToString());
                        number.Clear();
                        X++;
                    }
                }

                line = reader.ReadLine();
                Y++;
            }
        }
    }

    static int GetGreatestSum(int[,] matrix)
    {
        int greatestSum = int.MinValue;

        for (int i = 0; i < matrix.GetLength(0) - 1; i++)
        {
            for (int j = 0; j < matrix.GetLength(1) - 1; j++)
            {
                int sum = 0;

                for (int x = i; x < i + 2; x++)
                {
                    for (int z = j; z < j + 2; z++)
                    {
                        sum += matrix[x, z];
                    }
                }

                if (sum > greatestSum)
                {
                    greatestSum = sum;
                }
            }
        }

        return greatestSum;
    }

    static void Main()
    {
        string inputPath = "textFile.txt";
        string outputPath = "result.txt";
        int[,] matrix;
        StreamReader reader = new StreamReader(inputPath);

        using (reader)
        {
            int matrixSize = int.Parse(reader.ReadLine());
            matrix = new int[matrixSize, matrixSize];
            FillMatrix(reader, matrix);
        }

        StreamWriter output = new StreamWriter(outputPath);

        using (output)
        {
            output.WriteLine(GetGreatestSum(matrix));
        }
    }
}