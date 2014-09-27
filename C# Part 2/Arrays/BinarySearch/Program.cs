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
            Console.WriteLine("Contents of cell {0}", i);
            numbers[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Which is the number that we are searching for?");
        int searchedNumber = int.Parse(Console.ReadLine());

        //Solution
        bool found = false;
        int l = 0, r = numbers.Length, m;
        do
        {
            m = (l + r) / 2;
            if (numbers[m] == searchedNumber)
            {

                //Output
                Console.WriteLine("The index of the searched number is {0}", m);
                found = true;

            }
            else if (numbers[m] < searchedNumber)
            {
                l = m + 1;
            }
            else if (numbers[m] > searchedNumber)
            {
                r = m - 1;
            }
        } while (!found);
    }
}
