using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Threading;

class Calculate
{
    static List<char> arithmeticOperators = new List<char>() { '+', '-', '*', '/' };
    static List<string> arithmeticFunctions = new List<string>() { "pow", "sqrt", "ln" };
    static List<char> brackets = new List<char>() { '(', ')' };

    static List<string> SeparateTokens(string input)
    {
        List<string> result = new List<string>();
        StringBuilder number = new StringBuilder();

        for (int i = 0; i < input.Length; i++)
        {
            if (number.Length > 0 && !char.IsDigit(input[i]) && input[i] != '.')
            {
                result.Add(number.ToString());
                number.Clear();
            }

            if (input[i] == '-' && (i == 0 || input[i - 1] == ',' || input[i - 1] == '(' || arithmeticOperators.Contains(input[i - 1])))
            {
                number.Append('-');
            }
            else if (char.IsDigit(input[i]) || input[i] == '.')
            {
                number.Append(input[i]);
            }
            else if (arithmeticOperators.Contains(input[i]))
            {
                result.Add(input[i].ToString());
            }
            else if (brackets.Contains(input[i]))
            {
                result.Add(input[i].ToString());
            }
            else if (i + 1 < input.Length && input.Substring(i, 2) == "ln")
            {
                result.Add("ln");
                i += 1;
            }
            else if (i + 2 < input.Length && input.Substring(i, 3) == "pow")
            {
                result.Add("pow");
                i += 2;
            }
            else if (i + 3 < input.Length && input.Substring(i, 4) == "sqrt")
            {
                result.Add("sqrt");
                i += 3;
            }
        }

        if (number.Length > 0)
        {
            result.Add(number.ToString());
        }

        return result;
    }

    static int GetPrecedence(string oper)
    {
        if (oper == "+" || oper == "-")
        {
            return 1;
        }
        else
        {
            return 2;
        }
    }

    static Queue<string> ShuntingYard(List<string> tokens)
    {
        string currentToken;
        double number;
        var queue = new Queue<string>();
        var stack = new Stack<string>();

        for (int i = 0; i < tokens.Count; i++)
        {
            currentToken = tokens[i];

            if (double.TryParse(currentToken, out number))
            {
                queue.Enqueue(number.ToString());
            }
            else if (arithmeticFunctions.Contains(currentToken))
            {
                stack.Push(currentToken);
            }
            else if (currentToken == ",")
            {
                if (!queue.Contains("("))
                {
                    throw new ArithmeticException("Parentheses are misplaced.");
                }
                else
                {
                    while (queue.Peek() != "(")
                    {
                        queue.Enqueue(stack.Pop());
                    }
                }
            }
            else if (arithmeticOperators.Contains(currentToken[0]))
            {
                while (stack.Count > 0 && arithmeticOperators.Contains(stack.Peek()[0]) && GetPrecedence(currentToken) <= GetPrecedence(stack.Peek()))
                {
                    queue.Enqueue(stack.Pop());
                }

                stack.Push(currentToken);
            }
            else if (currentToken == "(")
            {
                stack.Push("(");
            }
            else if (currentToken == ")")
            {
                if (!stack.Contains("("))
                {
                    throw new ArithmeticException("Parentheses are misplaced.");
                }

                while (stack.Peek() != "(")
                {
                    queue.Enqueue(stack.Pop());
                }

                stack.Pop();

                if (stack.Count > 0 && arithmeticFunctions.Contains(stack.Peek()))
                {
                    queue.Enqueue(stack.Pop());
                }
            }
        }

        while (stack.Count > 0)
        {
            if (stack.Peek() == "(")
            {
                throw new ArithmeticException("Parentheses are misplaced.");
            }

            queue.Enqueue(stack.Pop());
        }

        return queue;
    }

    static double GetResult(Queue<string> queue)
    {
        Stack<double> stack = new Stack<double>();
        string currentToken;
        double number = 0;

        while (queue.Count > 0)
        {
            currentToken = queue.Dequeue();

            if (double.TryParse(currentToken, out number))
            {
                stack.Push(number);
            }
            else if (arithmeticFunctions.Contains(currentToken) || arithmeticOperators.Contains(currentToken[0]))
            {
                if (currentToken == "+")
                {
                    if (stack.Count < 2)
                    {
                        throw new ArithmeticException("Sufficient values are not input.");
                    }

                    double firstValue = stack.Pop();
                    double secondValue = stack.Pop();

                    stack.Push(firstValue + secondValue);
                }
                else if (currentToken == "-")
                {
                    if (stack.Count < 2)
                    {
                        throw new ArithmeticException("Sufficient values are not input.");
                    }

                    double firstValue = stack.Pop();
                    double secondValue = stack.Pop();

                    stack.Push(secondValue - firstValue);
                }
                else if (currentToken == "*")
                {
                    if (stack.Count < 2)
                    {
                        throw new ArithmeticException("Sufficient values are not input.");
                    }

                    double firstValue = stack.Pop();
                    double secondValue = stack.Pop();

                    stack.Push(secondValue * firstValue);
                }
                else if (currentToken == "/")
                {
                    if (stack.Count < 2)
                    {
                        throw new ArithmeticException("Sufficient values are not input.");
                    }

                    double firstValue = stack.Pop();
                    double secondValue = stack.Pop();

                    stack.Push(secondValue / firstValue);
                }
                else if (currentToken == "pow")
                {
                    if (stack.Count < 2)
                    {
                        throw new ArithmeticException("Sufficient values are not input.");
                    }

                    double firstValue = stack.Pop();
                    double secondValue = stack.Pop();

                    stack.Push(Math.Pow(secondValue, firstValue));
                }
                else if (currentToken == "ln")
                {
                    if (stack.Count < 1)
                    {
                        throw new ArithmeticException("Sufficient values are not input.");
                    }

                    double firstValue = stack.Pop();

                    stack.Push(Math.Log(firstValue));
                }
                else if (currentToken == "sqrt")
                {
                    if (stack.Count < 1)
                    {
                        throw new ArithmeticException("Sufficient values are not input.");
                    }

                    double firstValue = stack.Pop();

                    stack.Push(Math.Sqrt(firstValue));
                }
            }
        }

        if (stack.Count == 1)
        {
            return stack.Pop();
        }
        else
        {
            throw new ArithmeticException("There are too many input values.");
        }
    }

    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        string input = Console.ReadLine();
        input = input.Replace(" ", String.Empty);

        var tokens = SeparateTokens(input);
        var queue = ShuntingYard(tokens);
        var result = GetResult(queue);

        Console.WriteLine(result);
    }
}