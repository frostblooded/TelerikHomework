using System;

class HexadecimalToDecimal
{
    static int GetMultiplier(char character)
    {
        int multiplier = 0;
        if (character >= 'A' && character <= 'Z')
        {
            switch (character)
            {
                case 'A':
                    multiplier = 10;
                    break;
                case 'B':
                    multiplier = 11;
                    break;
                case 'C':
                    multiplier = 12;
                    break;
                case 'D':
                    multiplier = 13;
                    break;
                case 'E':
                    multiplier = 14;
                    break;
                case 'F':
                    multiplier = 15;
                    break;
            }
        }
        else
        {
            multiplier = (int)(character - '0');
        }
        return multiplier;
    }

    static int ConvertHexadecimalToDecimal(string hexadecimalNumber)
    {
        int decimalNumber = 0;
        for (int i = 0; i < hexadecimalNumber.Length; i++)
        {
            int multiplier = 1;
            multiplier = GetMultiplier(hexadecimalNumber[i]);
            decimalNumber += multiplier * (int)Math.Pow(16, hexadecimalNumber.Length - (i + 1));
        }
        return decimalNumber;
    }

    static void Main()
    {
        //Input
        Console.WriteLine("Which is the number that you want to convert?");
        string number = Console.ReadLine();

        //Output
        Console.WriteLine(ConvertHexadecimalToDecimal(number));
    }
}
