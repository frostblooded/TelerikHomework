using System;

namespace PrintDeck
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 1; j <= 13; j++)
                {
                    switch(j)
                    {
                        case 1:
                            Console.Write("Ace");
                            break;
                        case 2:
                            Console.Write("Two");
                            break;
                        case 3:
                            Console.Write("Three");
                            break;
                        case 4:
                            Console.Write("Four");
                            break;
                        case 5:
                            Console.Write("Five");
                            break;
                        case 6:
                            Console.Write("Six");
                            break;
                        case 7:
                            Console.Write("Seven");
                            break;
                        case 8:
                            Console.Write("Eight");
                            break;
                        case 9:
                            Console.Write("Nine");
                            break;
                        case 10:
                            Console.Write("Ten");
                            break;
                        case 11:
                            Console.Write("Jack");
                            break;
                        case 12:
                            Console.Write("Queen");
                            break;
                        case 13:
                            Console.Write("King");
                            break;
                    }
                    Console.Write(" of ");
                    switch (i)
                    {
                        case 0:
                            Console.WriteLine("Clubs");
                            break;
                        case 1:
                            Console.WriteLine("Diamonds");
                            break;
                        case 2:
                            Console.WriteLine("Hearts");
                            break;
                        case 3:
                            Console.WriteLine("Spades");
                            break;
                    }
                }
            }
        }
    }
}
