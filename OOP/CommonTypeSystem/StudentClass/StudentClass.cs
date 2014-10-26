using System;

namespace StudentClass
{
    class StudentClass
    {
        static void Main()
        {
            Student first = new Student("Nikolay", "Martinov", "Danailov", "0897850537");
            Student second = new Student("Nikolay", "Martinov", "Danailov", "0897850537");

            Console.WriteLine(first != second);
        }
    }
}
