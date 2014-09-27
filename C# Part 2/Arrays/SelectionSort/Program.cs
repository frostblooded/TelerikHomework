using System;


class Program
{
    static void Main()
    {
        //Input
        Console.WriteLine("Length?");
        int length = int.Parse(Console.ReadLine());
        int[] numbers = new int[length];
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        //Solution
        int min;
        for (int i = 0; i < numbers.Length; i++)
        {
            min = i;
            for (int j = i; j < numbers.Length; j++)
            {
                if (numbers[j] < numbers[min])
                {
                    min = j;
                }
            }
            int placeHolder = numbers[i];
            numbers[i] = numbers[min];
            numbers[min] = placeHolder;
        }

        //Output
        Console.WriteLine();
        Console.WriteLine();
        for (int i = 0; i < length; i++)
        {
            Console.WriteLine(numbers[i]);
        }
    }
}
    
