using System;
using System.Linq;

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
        int mostFrequentNumberValue = numbers[0], mostFrequentNumberCount = 0;

        //Find smallest number
        int min = numbers[0];
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] < min)
            {
                min = numbers[i];
            }
        }

        //Find biggest number
        int max = numbers[0];
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] > max)
            {
                max = numbers[i];
            }
        }

        //Main Solution Part
        for (int i = min; i <= max; i++)
        {
            if (numbers.Contains(i))
            {
                int currentCount = 0;
                for (int j = 0; j < numbers.Length; j++)
                {
                    if (numbers[j] == i)
                    {
                        currentCount++;
                    }
                }
                if (currentCount > mostFrequentNumberCount)
                {
                    mostFrequentNumberCount = currentCount;
                    mostFrequentNumberValue = i;
                }
            }
        }

        //Output
        Console.WriteLine("Most frequent number is {0} and it is found {1} times", mostFrequentNumberValue, mostFrequentNumberCount);
    }
}
