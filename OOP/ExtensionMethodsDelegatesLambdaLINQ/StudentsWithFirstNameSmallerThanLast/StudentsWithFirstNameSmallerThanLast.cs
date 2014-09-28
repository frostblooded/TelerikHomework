using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentsWithFirstNameSmallerThanLast
{
    class StudentsWithFirstNameSmallerThanLast
    {
        static IEnumerable<Student> GetStudentsWithFirstNameSmaller(Student[] students)
        {
            return students.Where(st => st.FirstName.CompareTo(st.LastName) < 0);
        }

        static IEnumerable<Student> GetStudentsBetween18And24(Student[] students)
        {
            return students.Where(st => st.Age >= 18 && st.Age <= 24);
        }

        static void Main()
        {
            var students = new Student[]
            {
                new Student
                {
                    FirstName = "Antonio",
                    LastName = "Mindov",
                    Age = 16
                },

                new Student
                {
                    FirstName = "Nikolay",
                    LastName = "Danailov",
                    Age = 19
                },

                new Student
                {
                    FirstName = "Petur",
                    LastName = "Petrov",
                    Age = 25
                },

                new Student
                {
                    FirstName = "Georgi",
                    LastName = "Nedkov",
                    Age = 21
                },
            };

            Console.WriteLine("Students with first name smaller than last name(alphabetically):");
            GetStudentsWithFirstNameSmaller(students).ForEach(Console.WriteLine);
            Console.WriteLine();
            Console.WriteLine("Students between 18 and 24 years:");
            GetStudentsBetween18And24(students).ForEach(Console.WriteLine);
        }
    }
}
