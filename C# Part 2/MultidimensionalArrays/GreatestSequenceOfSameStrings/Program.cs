using System;

class Program
{
    static void Main()
    {

        //Input
        Console.WriteLine("What is the height of the matrix? (Must be more than 2)");
        int matrixHeight = int.Parse(Console.ReadLine());
        Console.WriteLine("What is the width of the matrix? (must be more than 2)");
        int matrixWidth = int.Parse(Console.ReadLine());
        string[,] matrix = new string[matrixHeight, matrixWidth];
        for (int i = 0; i < matrixHeight; i++)
        {
            for (int j = 0; j < matrixWidth; j++)
            {
                Console.Write("Matrix[{0},{1}] = ", i, j);
                matrix[i, j] = Console.ReadLine();
            }
        }

        //Solve
        string longestSequenceString = null, checkedString;
        int longestSequenceLength = 0;
        int currentX = 0, currentY = 0;
        for (int i = 0; i < matrixHeight; i++)
        {
            for (int j = 0; j < matrixWidth; j++)
            {
                checkedString = matrix[i, j];
                int currentLength = 0;

                /*
                 * This loop checks all directions for sequences as follows:
                 * For z = 
                 *  1: Horizontally Down And Right
                 *  2: Horizontally Down And Left
                 *  3: Up
                 *  4: Right
                 *  5: Down
                 *  6: Left
                 */
                for (int z = 1; z <= 6; z++) 
                {
                    currentLength = 0;
                    currentX = j;
                    currentY = i;
                    bool stopCycle = false; //We need this to stop the cycle because "break" can only stop the switch
                    while (matrix[currentY, currentX] == checkedString && !stopCycle)
                    {
                        currentLength++;
                        switch(z)
                        {
                            case 1:
                                if (currentX == matrixWidth - 1 || currentY == matrixHeight - 1)
                                {
                                    stopCycle = true;
                                    break;
                                }
                                currentX++;
                                currentY++;
                                break;
                            case 2:
                                if (currentX == 0 || currentY == matrixHeight - 1)
                                {
                                    stopCycle = true;
                                    break;
                                }
                                currentX--;
                                currentY++;
                                break;
                            case 3:
                                if (currentY == 0)
                                {
                                    stopCycle = true;
                                    break;
                                }
                                currentY--;
                                break;
                            case 4:
                                if (currentX == matrixWidth - 1)
                                {
                                    stopCycle = true;
                                    break;
                                }
                                currentX++;
                                break;
                            case 5:
                                if (currentY == matrixHeight - 1)
                                {
                                    stopCycle = true;
                                    break;
                                }
                                currentY++;
                                break;
                            case 6:
                                if (currentX == 0)
                                {
                                    stopCycle = true;
                                    break;
                                }
                                currentX--;
                                break;
                        }
                    }
                    if (currentLength > longestSequenceLength)
                    {
                        longestSequenceLength = currentLength;
                        longestSequenceString = checkedString;
                    }
                }
            }
        }

        //Output
        Console.WriteLine();
        Console.WriteLine("Longest sequence:");
        for (int i = 0; i < longestSequenceLength; i++)
        {
            Console.Write(longestSequenceString);
            if (i != longestSequenceLength - 1)
            {
                Console.Write(", ");
            }
        }
    }
}
