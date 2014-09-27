using System;

class Program
{
    static void Main()
    {
        int? greatestSequenceValue = null;
        int greatestSequenceLength = 0;

        //Input
        Console.WriteLine("Length?");
        int length = int.Parse(Console.ReadLine());
        int[] numbers = new int[length];
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        //Solve
        for (int i = 0; i < length; i++)
        {
            int j = i;
            //Saves time but watches out for out of range exception
            if (j + 1 < length)
            {
                j++;
            }
            do
            {
                if (numbers[i] != numbers[j])
                {
                    break;
                }
                j++;
            } while (j < length);
            if (j - i > greatestSequenceLength)
            {
                greatestSequenceLength = j - i;
                greatestSequenceValue = numbers[i];
            }
            i = j - 1;
        }

        //Output
        for (int i = 0; i < greatestSequenceLength; i++)
        {
            Console.Write("{0}, ", greatestSequenceValue);
        }
    }
}