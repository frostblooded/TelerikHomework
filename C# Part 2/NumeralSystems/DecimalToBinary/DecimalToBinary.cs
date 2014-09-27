using System;

class DecimalToBinary
{
    public static string ReverseString(string usedString)
    {
        char[] charArray = usedString.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }

    static string ConvertDecimalToBinary(int decimalNumber)
    {
        string result = null;
        while(decimalNumber > 0)
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
        Console.WriteLine("Which is the number that you want to convert?");
        int number = int.Parse(Console.ReadLine());

        //Output
        Console.WriteLine(ConvertDecimalToBinary(number));
    }
}
