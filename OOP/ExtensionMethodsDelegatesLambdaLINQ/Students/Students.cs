using System;
using System.Collections.Generic;
using System.Linq;

namespace Students
{
    class Students
    {
        static void Main()
        {
            List<Student> students = new List<Student>
            {
                new Student("Nikolay", "Danailov", 1, "frostblooded@yahoo.com", "029584950", new List<int> { 6, 6, 5, 6, 4 }),
                new Student("Anonio", "Mindov", 1, "antonio.da@abv.bg", "039543456", new List<int> { 5, 4, 3, 2, 2 }),
                new Student("Petar", "Petrov", 2, "pesho@gmail.com", "024532367", new List<int> { 6, 6, 6, 6, 6 }),
                new Student("Histo", "Ezekiev", 2, "histo@abv.bg", "144556234", new List<int> { 4, 5, 4, 2, 3, 2 })
            };

            var studentsWithAnA = 
                students
                .Where(st => MarkCount(st.Marks, 2) == 2)
                .Select(st => new 
                {
                    FullName = st.FirstName + " " + st.LastName,
                    Marks = st.Marks
                });

            foreach (var student in studentsWithAnA)
            {
                Console.Write("{0} - Marks: ", student.FullName);

                foreach (var mark in student.Marks)
                {
                    Console.Write(mark + " ");
                }

                Console.WriteLine();
            }
        }

        private static int MarkCount(List<int> marks, int searchedMark)
        {
            int counter = 0;

            foreach (var mark in marks)
            {
                if (mark == searchedMark)
                {
                    counter++;
                }
            }

            return counter;
        }
    }
}
