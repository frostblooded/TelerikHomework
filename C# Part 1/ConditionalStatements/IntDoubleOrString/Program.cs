using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntDoubleOrString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Do you want to use an integer, a double or a string? (i, d, s)");
            Console.WriteLine("Also enter its value after that.");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "i":
                    int i = int.Parse(Console.ReadLine());
                    i++;
                    Console.WriteLine(i);
                    break;
                case "d":
                    double d = double.Parse(Console.ReadLine());
                    d++;
                    Console.WriteLine(d);
                    break;
                case "s":
                    string s = Console.ReadLine();
                    s += "*";
                    Console.WriteLine(s);
                    break;
                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }
        }
    }
}
