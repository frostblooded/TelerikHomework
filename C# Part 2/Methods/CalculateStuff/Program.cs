using System;

class CalculateStuff
{
    static T Minimum<T>(T[] numbers)
    {
        dynamic min = numbers[0];
        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] < min)
            {
                min = numbers[i];
            }
        }
        return min;
    }

    static T Maximum<T>(T[] numbers)
    {
        dynamic max = numbers[0];
        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] > max)
            {
                max = numbers[i];
            }
        }
        return max;
    }

    static T CalculateAverage<T>(T[] numbers)
    {
        dynamic result = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            result += numbers[i];
        }
        result /= numbers.Length;
        return result;
    }

    static T CalculateSum<T>(T[] numbers)
    {
        dynamic result = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            result = result + numbers[i];
        }
        return result;
    }

    static T CalculateProduct<T>(T[] numbers)
    {
        dynamic result = 1;
        for (int i = 0; i < numbers.Length; i++)
        {
            result = result * numbers[i];
        }
        return result;
    }

    static void PrintEverything<T>(T[] numbers)
    {
        Console.WriteLine();

        //Min
        Console.WriteLine("Min: {0}", Minimum(numbers));

        //Max
        Console.WriteLine("Max: {0}", Maximum(numbers));

        //Average
        Console.WriteLine("Average: {0:0.00}", CalculateAverage(numbers));

        //Sum
        Console.WriteLine("Sum: {0}", CalculateSum(numbers));

        //Product
        Console.WriteLine("Product: {0:0.00}", CalculateProduct(numbers));
    }

    static void Main()
    {
        double[] numbers = new double[5] { 4.231, 453.6, 123.43, 324.7, 78.3 };

        PrintEverything(numbers);
    }
}

