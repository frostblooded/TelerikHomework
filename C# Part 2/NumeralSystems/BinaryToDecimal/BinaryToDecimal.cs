using System;

class BinaryToDecimal
{
    static int ConvertBinaryToDecimal(string binaryNumber)
    {
        int decimalNumber = 0;
        for (int i = 0; i < binaryNumber.Length; i++)
        {
            decimalNumber += (int)(binaryNumber[i] - '0') * (int)Math.Pow(2, binaryNumber.Length - (i + 1));
        }
        return decimalNumber;
    }

    static void Main()
    {
        //Input
        Console.WriteLine("Which is the number that you want to convert?");
        string number = Console.ReadLine();

        //Output
        Console.WriteLine(ConvertBinaryToDecimal(number));
    }
}
