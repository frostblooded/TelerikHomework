using System;

namespace SpiralNumbers
{
    class Program
    {
        static byte direction = 1, currentX = 0, currentY = 0;

        static void ChangeCurrentPosition()
        {
            switch(direction)
            {
                case 0:
                    currentY -= 3;
                    break;
                case 1:
                    currentX += 4;
                    break;
                case 2:
                    currentY += 3;
                    break;
                case 3:
                    currentX -= 4;
                    break;
            }
        }

        static void PrintCell(byte x, byte y, byte value)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(value);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("N?");
            int n = int.Parse(Console.ReadLine());
            byte reduction = 0, repeats = 1, currentCell = 1;
            Console.Clear();
            do
            {
                for (int i = 0; i < repeats; i++)
                {
                    for (int j = 0; j < n - reduction; j++)
                    {
                        if (currentCell != 1)
                        {
                            ChangeCurrentPosition();
                        }
                        PrintCell(currentX, currentY, currentCell);
                        currentCell++;
                    }
                    if (direction < 3)
                    {
                        direction++;
                    }
                    else
                    {
                        direction = 0;
                    }
                }
                reduction++;
                if (repeats == 1)
                {
                    repeats = 2;
                }
            } while (currentCell < n * n);
            Console.ReadLine();
        }
    }
}
