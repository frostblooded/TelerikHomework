﻿using System;
using System.Text;

class HexadecimalToBinary
{
    static string ConvertHexadecimalToBinary(string hexadecimalNumber)
    {
        string binaryNumber = null;
        for (int i = 0; i < hexadecimalNumber.Length; i++)
        {
            switch(hexadecimalNumber[i])
            {
                case '1':
                    binaryNumber += "0001";
                    break;
                case '2':
                    binaryNumber += "0010";
                    break;
                case '3':
                    binaryNumber += "0011";
                    break;
                case '4':
                    binaryNumber += "0100";
                    break;
                case '5':
                    binaryNumber += "0101";
                    break;
                case '6':
                    binaryNumber += "0110";
                    break;
                case '7':
                    binaryNumber += "0111";
                    break;
                case '8':
                    binaryNumber += "1000";
                    break;
                case '9':
                    binaryNumber += "1001";
                    break;
                case 'A':
                    binaryNumber += "1010";
                    break;
                case 'B':
                    binaryNumber += "1011";
                    break;
                case 'C':
                    binaryNumber += "1100";
                    break;
                case 'D':
                    binaryNumber += "1101";
                    break;
                case 'E':
                    binaryNumber += "1110";
                    break;
                case 'F':
                    binaryNumber += "1111";
                    break;
            }
        }
        return binaryNumber;
    }

    static void Main()
    {
        //Input
        Console.WriteLine("Input a number for convertion.");
        string number = Console.ReadLine();

        //Output
        Console.WriteLine(ConvertHexadecimalToBinary(number));
    }
}
