using System;

class BracketsCheck
{
    static void Main()
    {
        string input = Console.ReadLine();
        int openBrackets = 0;

        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] == '(')
            {
                openBrackets++;
            }
            else if (input[i] == ')')
            {
                openBrackets--;
            }
        }

        if (openBrackets == 0)
        {
            Console.WriteLine("The brackets are put correctly.");
        }
        else
        {
            Console.WriteLine("The brackets are put incorrectly.");
        }
    }
}
