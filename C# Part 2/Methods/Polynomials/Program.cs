using System;

class Program
{

    static void Output(int[] polynomial)
    {
        for (int i = polynomial.Length - 1; i >= 0; i--)
        {
            if (polynomial[i] != 0)
            {
                if (polynomial[i] != 1)
                {
                    if (polynomial[i] == -1)
                    {
                        Console.Write("-");
                    }
                    else
                    {
                        Console.Write(polynomial[i]);
                    }
                }
                if (i != 0)
                {
                    Console.Write("x", i);
                    if (i > 1)
                    {
                        Console.Write("^{0}", i);
                    }
                    Console.Write(" + ");
                }
            }
        }
    }

    static int[] AddPolynomials(int[] firstPolynomial, int[] secondPolynomial)
    {
        int[] result = new int[Math.Max(firstPolynomial.Length, secondPolynomial.Length)];  //Gets the greater length

        for (int i = 0; i < result.Length; i++)
        {
            if (i < firstPolynomial.Length)
            {
                result[i] += firstPolynomial[i];
            }

            if (i < secondPolynomial.Length)
            {
                result[i] += secondPolynomial[i];
            }
        }

        return result;
    }

    static int[] SubstractPolynomials(int[] firstPolynomial, int[] secondPolynomial)
    {
        int[] result = new int[Math.Max(firstPolynomial.Length, secondPolynomial.Length)];  //Gets the greater length

        for (int i = 0; i < result.Length; i++)
        {
            if (i < firstPolynomial.Length)
            {
                result[i] += firstPolynomial[i];
            }

            if (i < secondPolynomial.Length)
            {
                result[i] -= secondPolynomial[i];
            }
        }

        return result;
    }

    static int[] MultiplyPolynomials(int[] firstPolynomial, int[] secondPolynomial)
    {
        int[] result = new int[firstPolynomial.Length + secondPolynomial.Length];
        for (int i = 0; i < firstPolynomial.Length; i++)
        {
            for (int j = 0; j < secondPolynomial.Length; j++)
            {
                result[i + j] += firstPolynomial[i] * secondPolynomial[j];
            }
        }
        return result;
    }

    static void Main()
    {
        //Input
        int[] firstPolynomial = new int[5] { 4, 6, 2, 9, -3 };
        int[] secondPolynomial = new int[3] { 3, 0, -5 };

        //Output
        //First
        Console.WriteLine();
        Console.Write("First: ");
        Output(firstPolynomial);

        //Second
        Console.WriteLine();
        Console.Write("Second: ");
        Output(secondPolynomial);

        //Adding Result
        Console.WriteLine();
        Console.Write("When Added: ");
        Output(AddPolynomials(firstPolynomial, secondPolynomial));

        //Substraction Result
        Console.WriteLine();
        Console.Write("When Substracted: ");
        Output(SubstractPolynomials(firstPolynomial, secondPolynomial));

        //Substraction Result
        Console.WriteLine();
        Console.Write("When Multiplied: ");
        Output(MultiplyPolynomials(firstPolynomial, secondPolynomial));

        Console.WriteLine(); //Stylistic
    }
}
