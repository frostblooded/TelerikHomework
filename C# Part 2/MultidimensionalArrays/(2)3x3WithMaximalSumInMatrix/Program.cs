using System;

class Program
{
    static void Main()
    {
        //Input
        Console.WriteLine("What is the height of the matrix? (Must be more than 2)");
        int matrixHeight = int.Parse(Console.ReadLine());
        Console.WriteLine("Whati is the width of the matrix? (must be more than 2)");
        int matrixWidth = int.Parse(Console.ReadLine());
        int[,] matrix = new int[matrixHeight, matrixWidth];
        for (int i = 0; i < matrixHeight; i++)
        {
            for (int j = 0; j < matrixWidth; j++)
            {
                Console.Write("Matrix[{0},{1}] = ", i, j);
                matrix[i, j] = int.Parse(Console.ReadLine());
            }
        }

        //Print Matrix
        Console.WriteLine();
        Console.WriteLine("The Matrix");
        Console.WriteLine();
        for (int i = 0; i < matrixHeight; i++)
        {
            for (int j = 0; j < matrixWidth; j++)
            {
                Console.Write(matrix[i,j] + " ");
            }
            Console.WriteLine();
        }

        //Solve
        int biggestSum = 0, biggestSumX = 0, biggestSumY = 0; //X and Y of top left corner
        for (int i = 0; i <= matrixHeight - 3; i++)
        {
            for (int j = 0; j <= matrixWidth - 3; j++)
            {
                int currentSum = 0;
                for (int YCounter = i; YCounter < i + 3; YCounter++)
                {
                    for (int XCounter = j; XCounter < j + 3; XCounter++)
                    {
                        currentSum += matrix[YCounter, XCounter];
                    }
                }
                if (currentSum > biggestSum)
                {
                    biggestSum = currentSum;
                    biggestSumX = j;
                    biggestSumY = i;
                }
            }
        }

        //Output
        Console.WriteLine();
        Console.WriteLine("Biggest 3x3 grid");
        Console.WriteLine();
        for (int i = biggestSumY; i < biggestSumY + 3; i++)
        {
            for (int j = biggestSumX; j < biggestSumX + 3; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine("It's sum is {0}", biggestSum);
    }
}
