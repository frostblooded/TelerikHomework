using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Three_DigitNumberInWords
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input the number.");
            string number = Console.ReadLine();
            if (number == "0")
            {
                Console.Write("zero");
            }
            else
            {
                for (int i = 0; number.Length < 3; i++)
                {
                    number = "0" + number;
                }
                if (number[0] != '0')
                {
                    switch (number[0])
                    {
                        case '1':
                            Console.Write("one");
                            break;
                        case '2':
                            Console.Write("two");
                            break;
                        case '3':
                            Console.Write("three");
                            break;
                        case '4':
                            Console.Write("four");
                            break;
                        case '5':
                            Console.Write("five");
                            break;
                        case '6':
                            Console.Write("six");
                            break;
                        case '7':
                            Console.Write("seven");
                            break;
                        case '8':
                            Console.Write("eight");
                            break;
                        case '9':
                            Console.Write("nine");
                            break;
                    }
                    Console.Write(" hundred and ");
                }
                if (number[1] != '0')
                {
                    if (number[1] == '1')
                    {
                        switch (number[2])
                        {
                            case '1':
                                Console.Write("eleven");
                                break;
                            case '2':
                                Console.Write("twelve");
                                break;
                            case '3':
                                Console.Write("thirteen");
                                break;
                            case '4':
                                Console.Write("fourteen");
                                break;
                            case '5':
                                Console.Write("fifteen");
                                break;
                            case '6':
                                Console.Write("sixteen");
                                break;
                            case '7':
                                Console.Write("seventeen");
                                break;
                            case '8':
                                Console.Write("eighteen");
                                break;
                            case '9':
                                Console.Write("nineteen");
                                break;
                        }
                    }
                    else
                    {
                        if (number[1] != '1')
                        {
                            switch (number[1])
                            {
                                case '2':
                                    Console.Write("twenty");
                                    break;
                                case '3':
                                    Console.Write("thirty");
                                    break;
                                case '4':
                                    Console.Write("fourty");
                                    break;
                                case '5':
                                    Console.Write("fifty");
                                    break;
                                case '6':
                                    Console.Write("sixty");
                                    break;
                                case '7':
                                    Console.Write("seventy");
                                    break;
                                case '8':
                                    Console.Write("eighty");
                                    break;
                                case '9':
                                    Console.Write("ninety");
                                    break;
                            }
                        }
                    }

                    Console.Write(" ");
                }
                if (number[1] != '1')
                {
                    switch (number[2])
                    {
                        case '1':
                            Console.Write("one");
                            break;
                        case '2':
                            Console.Write("two");
                            break;
                        case '3':
                            Console.Write("three");
                            break;
                        case '4':
                            Console.Write("four");
                            break;
                        case '5':
                            Console.Write("five");
                            break;
                        case '6':
                            Console.Write("six");
                            break;
                        case '7':
                            Console.Write("seven");
                            break;
                        case '8':
                            Console.Write("eight");
                            break;
                        case '9':
                            Console.Write("nine");
                            break;
                    }
                }
            }
            Console.WriteLine();
        }
    }
}


