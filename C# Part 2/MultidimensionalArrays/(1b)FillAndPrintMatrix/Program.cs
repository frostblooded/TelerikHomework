using System;

class Program
{
    static int x = 0, y = 0; //The current x and y

    static void MoveForward(int direction)
    {
        switch (direction)
        {
            case 1:
                y--;
                break;
            case 2:
                x++;
                break;
            case 3:
                y++;
                break;
        }
    }

    static int ChangeDirection(int direction)
    {
        switch(direction)
        {
            case 1:
                return 2;
            case 2:
                if (y == 0)
                {
                    return 3;
                }
                else
                {
                    return 1;
                }

            case 3:
                return 2;
            default:
                return 0;
        }
    }

    static void Main()
    {
        //Input
        Console.WriteLine("What is the size of the matrix?");
        int size = int.Parse(Console.ReadLine());
        int[,] matrix = new int[size, size];

        //Filling
        int direction = 3; // 1 - Up, 2 - Right, 3 - Down
        for (int i = 0; i < size; i++)
        {
            for (int j = size * i + 1; j <= size + size * i; j++)
            {
                matrix[x, y] = j;
                if (j != size + size * i)
                {
                    MoveForward(direction);
                }

            }
            direction = ChangeDirection(direction);
            MoveForward(direction);
            direction = ChangeDirection(direction);
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
