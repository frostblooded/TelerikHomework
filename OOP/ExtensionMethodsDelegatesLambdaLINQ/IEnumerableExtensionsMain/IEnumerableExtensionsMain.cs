using System;
using System.Collections.Generic;

namespace IEnumerableExtensionsMain
{
    class IEnumerableExtensionsMain
    {
        static void Main()
        {
            List<int> someList = new List<int>();
            someList.Add(4);
            someList.Add(3);
            someList.Add(5);
            someList.Add(6);
            someList.Add(1);
            someList.Add(2);
            Console.WriteLine(someList.Sum());
            Console.WriteLine(someList.Product());
            Console.WriteLine(someList.Min());
            Console.WriteLine(someList.Max());
            Console.WriteLine(someList.Average());
        }
    }
}
