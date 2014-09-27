using System;

class Program
{
    static void Main(string[] args)
    {
        float a = 5.000001f, b = 5.000000f;
        float difAbs = Math.Abs(a - b);
        if (Math.Abs(a - b) < 0.000001)
        {
            Console.WriteLine(true);
        }
        else
        {
            Console.WriteLine(false);
        }
    }
}
