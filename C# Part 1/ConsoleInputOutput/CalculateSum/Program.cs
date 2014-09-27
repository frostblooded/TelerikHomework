using System;

class CalculateSumWithAccuracy
{
    static void Main()
    {
        double sum = 1.0, preSum = 2.0;
        for (float i = 2; Math.Abs(preSum - sum) > 0.001; i++)
        {
            preSum = sum;
            if (i % 2 == 0)
            {
                sum += 1 / i;
            }
            else
            {
                sum -= 1 / i;
            }
        }
        Console.WriteLine("The result is {0:0.000}", sum);
    }
}

