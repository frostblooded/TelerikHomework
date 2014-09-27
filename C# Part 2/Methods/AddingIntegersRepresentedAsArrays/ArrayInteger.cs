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
            if (numberAsString == null)
            {
                return -1;
            }
            return BigInteger.Parse(numberAsString);
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

    public void SetValue (string valueAsString)
    {
        number.Clear();
        for (int i = 0; i < valueAsString.Length; i++)
        {
            char addedChar = valueAsString[valueAsString.Length - (i + 1)];
            int charAsInt = (int)Char.GetNumericValue(addedChar);
            number.Add(charAsInt);
        }
    }
}

