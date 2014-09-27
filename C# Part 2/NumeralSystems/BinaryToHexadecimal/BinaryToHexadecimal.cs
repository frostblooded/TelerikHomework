using System;
using System.Text;

class BinaryToHexadecimal
{
    static string ConvertBinaryToHexadecimal(string binaryNumber)
    {
        string hexadecimalNumber = null;
        StringBuilder binaryNumberBuilder = new StringBuilder(binaryNumber);

        //Add zeroes
        while (binaryNumberBuilder.Length % 4 != 0)
        {
            binaryNumberBuilder.Insert(0, '0');
        }
        binaryNumber = binaryNumberBuilder.ToString();
        for (int i = 0; i < binaryNumber.Length / 4; i++)
        {
            string currentSubString = binaryNumber.Substring(i * 4, 4);
            switch(currentSubString)
            {
                case "0001":
                    hexadecimalNumber += "1";
                    break;
                case "0010":
                    hexadecimalNumber += "2";
                    break;
                case "0011":
                    hexadecimalNumber += "3";
                    break;
                case "0100":
                    hexadecimalNumber += "4";
                    break;
                case "0101":
                    hexadecimalNumber += "5";
                    break;
                case "0110":
                    hexadecimalNumber += "6";
                    break;
                case "0111":
                    hexadecimalNumber += "7";
                    break;
                case "1000":
                    hexadecimalNumber += "8";
                    break;
                case "1001":
                    hexadecimalNumber += "9";
                    break;
                case "1010":
                    hexadecimalNumber += "A";
                    break;
                case "1011":
                    hexadecimalNumber += "B";
                    break;
                case "1100":
                    hexadecimalNumber += "C";
                    break;
                case "1101":
                    hexadecimalNumber += "D";
                    break;
                case "1110":
                    hexadecimalNumber += "E";
                    break;
                case "1111":
                    hexadecimalNumber += "F";
                    break;
            }
        }

        return hexadecimalNumber;
    }

    static void Main()
    {
        //Input
        Console.WriteLine("Input a number for convertion.");
        string number = Console.ReadLine();

        //Output
        Console.WriteLine(ConvertBinaryToHexadecimal(number));
    }
}
