using System;

class Program
{
    static int CountOfNumberInArray(int[] array, int checkedNumber)
    {
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == checkedNumber)
            {
                count++;
            }
        }
        return count;
    }

    static void Main()
    {
        //Input
        Console.WriteLine("Length of the array?");
        int[] numbers = new int[int.Parse(Console.ReadLine())];
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine("numbers[{0}] = ", i);
            numbers[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Which number are you searching for?");
        int checkedNumber = int.Parse(Console.ReadLine());

        //Output
        Console.WriteLine();
        Console.WriteLine("{0} appears in the array {1} times.", checkedNumber, CountOfNumberInArray(numbers, checkedNumber));
    }
}
