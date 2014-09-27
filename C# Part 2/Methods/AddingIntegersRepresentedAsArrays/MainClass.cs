using System;
using System.Collections.Generic;

class MainClass
{
    static void Main()
    {
        ArrayInteger firstNumber = new ArrayInteger();
        ArrayInteger secondNumber = new ArrayInteger();
        firstNumber.SetValue("19999999999999999999999999999999999999999991111111111111111111111111111111");
        secondNumber.SetValue("2222222222222222222222222222222222222223333333333333333333333333333333333355555555555555555555555555555555555555");
        Console.WriteLine((firstNumber + secondNumber).Value);
    }
}
