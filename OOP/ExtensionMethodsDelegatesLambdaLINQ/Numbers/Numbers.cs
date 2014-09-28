using StudentsWithFirstNameSmallerThanLast;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Numbers
{
    class Numbers
    {
        static void Main()
        {
            int[] numbers = new int[] { 10, 5, 42, 7, 21, 3, 12, 16, 17 };
            Console.WriteLine("With extension methods:");
            GetDivisableBy7And3WithExtensionMethods(numbers).ForEach(Console.WriteLine);
            Console.WriteLine();
            Console.WriteLine("With LINQ");
            GetDivisableBy7And3WithLINQ(numbers).ForEach(Console.WriteLine);

        }

        private static IEnumerable<T> GetDivisableBy7And3WithLINQ<T>(T[] numbers)
        {
            var divisableBy7And3 =
                from number in numbers
                where (dynamic)number % 3 == 0 && (dynamic)number % 7 == 0
                select number;
            return divisableBy7And3;
        }

        private static IEnumerable<T> GetDivisableBy7And3WithExtensionMethods<T>(T[] numbers)
        {
            var divisableBy7And3 = numbers.Where(num => (dynamic)num % 7 == 0 && (dynamic)num % 3 == 0);
            return divisableBy7And3;
        }
    }
}
