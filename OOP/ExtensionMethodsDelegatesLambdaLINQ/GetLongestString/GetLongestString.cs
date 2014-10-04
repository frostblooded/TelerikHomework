using System;
using System.Linq;

namespace GetLongestString
{
    class GetLongestString
    {
        static void Main()
        {
            string[] strings = new string[] { "The", "man", "in", "black", "fled", "across", "the", "dessert", "and", "the", "gunslinger", "followed" };

            string longestString = strings.OrderByDescending(st => st.Length).First();

            Console.WriteLine(longestString);
        }
    }
}
