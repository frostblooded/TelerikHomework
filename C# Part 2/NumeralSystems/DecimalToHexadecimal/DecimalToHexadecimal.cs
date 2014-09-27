using System;

class DecimalToHexadecimal
{
    public static string ReverseString(string usedString)
    {
        char[] charArray = usedString.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }

    static string ConvertDecimalToHexidecimal(int decimalNumber)
    {
        string hexadecimalNumber = null;
        while (decimalNumber > 0)
        {
            int remainder = decimalNumber % 16;
            if (remainder < 10)
            {
                hexadecimalNumber += remainder;
            }
            else
            {
                switch (remainder)
                {
                    case 10:
                        hexadecimalNumber += 'A';
                        break;
                    case 11:
                        hexadecimalNumber += 'B';
                        break;
                    case 12:
                        hexadecimalNumber += 'C';
                        break;
                    case 13:
                        hexadecimalNumber += 'D';
                        break;
                    case 14:
                        hexadecimalNumber += 'E';
                        break;
                    case 15:
                        hexadecimalNumber += 'F';
                        break;
                }
            }
            decimalNumber /= 16;
        }
        hexadecimalNumber = ReverseString(hexadecimalNumber);
        return hexadecimalNumber;
    }

    static void Main()
    {
        //Input
        Console.WriteLine("Which is the number that you want to convert?");
        int number = int.Parse(Console.ReadLine());

        //Output
        Console.WriteLine(ConvertDecimalToHexidecimal(number));
    }
}
