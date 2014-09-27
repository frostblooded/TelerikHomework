using System;

public class Program
{
    public static void Main()
    {
         //Input
        Console.WriteLine("What is the size of the matrix?");
        int size = int.Parse(Console.ReadLine());
        int[,] matrix = new int[size, size];

         //Filling
        for (int i = 1; i <= size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                matrix[i - 1, j] = i + size * j; 
            }
        }

         //Output
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }

            Console.WriteLine();
        }
    }
}
