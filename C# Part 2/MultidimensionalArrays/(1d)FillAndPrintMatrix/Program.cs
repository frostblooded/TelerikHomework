using System;

class Program
{
    static int currentX = 0, currentY = 0;

    static void MoveForward(int direction)
    {
        switch(direction)
        {
            case 1:
                currentY--;
                break;
            case 2:
                currentX++;
                break;
            case 3:
                currentY++;
                break;
            case 4:
                currentX--;
                break;
        }
    }

    static int ChangeDirection(int direction)
    {
        switch(direction)
        {
            case 1:
                return 4;
            case 2:
                return 1;
            case 3:
                return 2;
            case 4:
                return 3;
            default:
                return 0;
        }
    }

    static bool CheckIfDirectionShouldChange(int direction, int[,] matrix, int matrixSize)
    {
        switch (direction)
        {
            case 1:
                if (currentY - 1 < matrixSize && currentY - 1 >= 0)
                {
                    if (matrix[currentX, currentY - 1] == 0)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
                else
                {
                    return true;
                }
            case 2:
                if (currentX + 1 < matrixSize && currentX + 1 >= 0)
                {
                    if (matrix[currentX + 1, currentY] == 0)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
                else
                {
                    return true;
                }
            case 3:
                if (currentY + 1 < matrixSize && currentY + 1 >= 0)
                {
                    if (matrix[currentX, currentY + 1] == 0)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
                else
                {
                    return true;
                }
            case 4:
                if (currentX - 1 < matrixSize && currentX - 1 >= 0)
                {
                    if (matrix[currentX - 1, currentY] == 0)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
                else
                {
                    return true;
                }
            default:
                return true;
        }
    }

    static void Main()
    {
        //Input
        Console.WriteLine("What is the size of the matrix?");
        int size = int.Parse(Console.ReadLine());
        int[,] matrix = new int[size, size];

        //Filling
        int direction = 3; // 1 - Up, 2 - Right, 3 - Down, 4 - Left (Clockwise)
        for (int currentNumber = 1; currentNumber <= size * size; currentNumber++)
        {
            matrix[currentX, currentY] = currentNumber;
            if (CheckIfDirectionShouldChange(direction, matrix, size))
            {
                direction = ChangeDirection(direction);
            }
            MoveForward(direction);
        }

        //Output
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                Console.Write(matrix[j, i] + " ");
            }
            Console.WriteLine();
        }
    }
}
