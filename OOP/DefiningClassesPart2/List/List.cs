using System;

namespace List
{
    class List
    {
        static void Main()
        {
            GenericList<int> list = new GenericList<int>();

            for (int i = 0; i < 20; i++)
            {
                list.Add(i);
            }

            Console.WriteLine(list.Min());
            Console.WriteLine(list.Max());
        }
    }
}
