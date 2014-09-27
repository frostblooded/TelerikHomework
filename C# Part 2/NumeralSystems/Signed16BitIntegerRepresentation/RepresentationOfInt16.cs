using System;
using System.Text;

class RepresentationOfInt16
{
    public static string ReverseString(string usedString)
    {
        char[] charArray = usedString.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }

    static string ConvertDecimalToBinary(int decimalNumber)
    {
        if (decimalNumber == 0)
        {
            return "000000000000000";
        }

        string result = null;
        
        while (decimalNumber > 0)
        {
            result += decimalNumber % 2;
            decimalNumber /= 2;
        }

        result = ReverseString(result);
        return result;
    }

    static void Main()
    {
        //Input
        short placeHolder = 0;
        do
        {
            Console.WriteLine("Which is the number? (-32,768 < n < 32,767)");
        } while (!short.TryParse(Console.ReadLine(), out placeHolder));
        int number = placeHolder;

        //Solve
        bool negative = number < 0;
        if (negative)
        {
            number = short.MaxValue - Math.Abs(number) + 1;
        }

        StringBuilder binaryNumber = new StringBuilder(ConvertDecimalToBinary(number));

        while (binaryNumber.Length < 15)
        {
            binaryNumber.Insert(0, "0");
        }

        if (negative)
        {
            binaryNumber.Insert(0, "1");
        }
        else
        {
            binaryNumber.Insert(0, "0");
        }

        //Output
        Console.WriteLine(binaryNumber);
    }
}