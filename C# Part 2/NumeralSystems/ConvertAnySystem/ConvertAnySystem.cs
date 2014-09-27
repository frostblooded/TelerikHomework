using System;

class ConvertAnySystem
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

    static int ToDecimal(string number, int firstBase)
    {
        int result = 0;
        for (int i = 0; i < number.Length; i++)
        {
            result += GetMultiplier(number[i]) * (int)Math.Pow(firstBase, number.Length - (i + 1));
        }
        return result;
    }

    static string ReverseString(string usedString)
    {
        char[] charArray = usedString.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }

    static string FromDecimal(int number, int secondBase)
    {
        string result = null;
        while (number > 0)
        {
            int remainder = number % secondBase;
            if (remainder < 10)
            {
                result += remainder;
            }
            else
            {
                switch (remainder)
                {
                    case 10:
                        result += 'A';
                        break;
                    case 11:
                        result += 'B';
                        break;
                    case 12:
                        result += 'C';
                        break;
                    case 13:
                        result += 'D';
                        break;
                    case 14:
                        result += 'E';
                        break;
                    case 15:
                        result += 'F';
                        break;
                }
            }
            number /= secondBase;
        }
        result = ReverseString(result);
        return result;
    }

    static string ConvertToAny(string number, int firstBase, int secondBase)
    {
        return FromDecimal(ToDecimal(number, firstBase), secondBase);
    }

    static void Main()
    {
        //Input
        Console.WriteLine("Which is the number that you want to convert?");
        string number = Console.ReadLine();
        Console.WriteLine("In which numerical system is it right now?");
        int firstSystemBase = int.Parse(Console.ReadLine());
        Console.WriteLine("In which numerical system do you want it to be?");
        int secondSystemBase = int.Parse(Console.ReadLine());

        //Solve and output
        Console.WriteLine(ConvertToAny(number, firstSystemBase, secondSystemBase));
    }
}