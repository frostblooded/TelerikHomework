using System;
using System.Collections.Generic;
using System.Numerics;

class ArrayInteger
{
    private List<int> number = new List<int>();

    public BigInteger Value
    {
        get
        {
            string numberAsString = null;
            for (int i = 0; i < number.Count; i++)
            {
                numberAsString += number[number.Count - (i + 1)];
            }
            return BigInteger.Parse(numberAsString);
        }
    }

    public void SetValue(string valueAsString)
    {
        number.Clear();
        for (int i = 0; i < valueAsString.Length; i++)
        {
            char addedChar = valueAsString[valueAsString.Length - (i + 1)];
            int charAsInt = (int)Char.GetNumericValue(addedChar);
            number.Add(charAsInt);
        }
    }

    public static ArrayInteger operator +(ArrayInteger firstNumber, ArrayInteger secondNumber)
    {
        ArrayInteger result = new ArrayInteger();
        for (int i = 0; i < Math.Max(firstNumber.number.Count, secondNumber.number.Count); i++)
        {
            if (i < firstNumber.number.Count)
            {
                if (result.number.Count <= i)
                {
                    result.number.Add(firstNumber.number[i]);
                }
                else
                {
                    result.number[i] += firstNumber.number[i];
                }
            }

            if (i < secondNumber.number.Count)
            {
                if (result.number.Count <= i) //If there isn't already a number there
                {
                    result.number.Add(secondNumber.number[i]);
                }
                else
                {
                    result.number[i] += secondNumber.number[i];
                }
            }

            if (result.number[i] > 9)
            {
                result.number.Add(1);
                result.number[i] -= 10;
            }
        }
        return result;
    }

    public static ArrayInteger operator *(ArrayInteger usedNumber, int multiplier)
    {
        for (int i = usedNumber.number.Count - 1; i >= 0; i--)
        {
            usedNumber.number[i] *= multiplier;
            for (int j = i; usedNumber.number[j] > 9; j++)
            {
                int remainder = usedNumber.number[j] / 10;
                usedNumber.number[j] %= 10;
                if (j + 1 >= usedNumber.number.Count)
                {
                    usedNumber.number.Add(remainder);
                }
                else
                {
                    usedNumber.number[j + 1] += remainder;
                }
            }
        }
        return usedNumber;
    }
}

