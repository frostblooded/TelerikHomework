using System;

class Program
{
    static void Main()
    {
        //Input
        Console.WriteLine("What is the size of the matrix?");
        int size = int.Parse(Console.ReadLine());
        int[,] matrix = new int[size, size];

        //Filling
        int startX = 0, startY = 1, currentX, currentY;
        int currentNumber = 2;
        matrix[0, 0] = 1;
        while (currentNumber <= size * size)
        {
            currentX = startX;
            currentY = startY;
            while (currentX <= size - 1 && currentY >= 0)
            {
                matrix[currentX, currentY] = currentNumber;
                currentNumber++;
                currentX++;
                currentY--;
            }
            
            //Change Start Position
            if (startY != size - 1)
            {
                startY++;
            }
            else
            {
                startX++;
            }

        }

        //Output
        for (int i = size - 1; i >= 0; i--)
        {
            for (int j = 0; j < size; j++)
            {
                Console.Write(matrix[j, i] + "  ");
            }
            Console.WriteLine();
        }
    }
}
