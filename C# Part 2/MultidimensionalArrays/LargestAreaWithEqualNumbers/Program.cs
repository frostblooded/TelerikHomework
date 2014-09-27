using System;

class Program
{
    static int?[,] matrix;
    static int currentFieldCount = 0;

    static void BrowseField(int currentY, int currentX, int? browsedValue)
    {
        matrix[currentY, currentX] = null;
        currentFieldCount++;

        //Up
        if (currentY != 0)
        {
            if (matrix[currentY - 1, currentX] == browsedValue)
            {
                BrowseField(currentY - 1, currentX, browsedValue);
            }
        }

        //Right
        if (currentX != matrix.GetLength(1) - 1)
        {
            if (matrix[currentY, currentX + 1] == browsedValue)
            {
                BrowseField(currentY, currentX + 1, browsedValue);
            }
        }

        //Down
        if (currentY != matrix.GetLength(0) - 1)
        {
            if (matrix[currentY + 1, currentX] == browsedValue)
            {
                BrowseField(currentY + 1, currentX, browsedValue);
            }
        }


        //Left
        if (currentX != 0)
        {
            if (matrix[currentY, currentX - 1] == browsedValue)
            {
                BrowseField(currentY, currentX - 1, browsedValue);
            }
        }
    }

    static void Main()
    {
        //Input
        Console.WriteLine("What is the width of the matrix?");
        int matrixWidth = int.Parse(Console.ReadLine());
        Console.WriteLine("What is the hight of the matrix?");
        int matrixHeight = int.Parse(Console.ReadLine());
        matrix = new int?[matrixHeight, matrixWidth];
        for (int i = 0; i < matrixHeight; i++)
        {
            for (int j = 0; j < matrixWidth; j++)
            {
                Console.WriteLine("matrix[{0},{1}] = ?", i, j);
                matrix[i, j] = int.Parse(Console.ReadLine());
            }
        }

        //Solution
        int greatestFieldCount = 0;
        int? greatestFieldValue = matrix[0, 0];
        for (int i = 0; i < matrixHeight; i++)
        {
            for (int j = 0; j < matrixWidth; j++)
            {
                if (matrix[i, j] != null)
                {
                    currentFieldCount = 0;
                    int? currentValue = matrix[i, j];
                    BrowseField(i, j, matrix[i, j]);
                    if (currentFieldCount > greatestFieldCount)
                    {
                        greatestFieldCount = currentFieldCount;
                        greatestFieldValue = currentValue;
                    }
                }
            }
        }

        //Output
        Console.WriteLine("{0} is found {1} times in a single area.", greatestFieldValue, greatestFieldCount);
    }
}
