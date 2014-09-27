using System;

class MainClass
{
    static ArrayInteger Factorial(int factorialCount)
    {
        ArrayInteger result = new ArrayInteger();
        result.SetValue("1");
        for (int i = 2; i <= factorialCount; i++)
        {
            result *= i;
        }
        return result;
    }

    static void Main()
    {
        ArrayInteger firstNumber = new ArrayInteger();
        Console.WriteLine("Factorial up to?");
        int factorialCount = int.Parse(Console.ReadLine());
        Console.WriteLine(Factorial(factorialCount).Value);

    }
}