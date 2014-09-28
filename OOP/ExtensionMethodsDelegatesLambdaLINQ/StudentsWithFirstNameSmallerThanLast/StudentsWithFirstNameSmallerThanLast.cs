using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentsWithFirstNameSmallerThanLast
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    class StudentsWithFirstNameSmallerThanLast
    {
        static IEnumerable<Student> GetStudentsWithFirstNameSmaller(Student[] students)
        {
            return students.Where(st => st.FirstName.CompareTo(st.LastName) < 0);
        }

        static void Main()
        {
            var students = new Student[]
            {
                new Student
                {
                    FirstName = "Antonio",
                    LastName = "Mindov"
                },

                new Student
                {
                    FirstName = "Nikolay",
                    LastName = "Danailov"
                },

                new Student
                {
                    FirstName = "Petur",
                    LastName = "Petrov"
                },

                new Student
                {
                    FirstName = "Georgi",
                    LastName = "Nedkov"
                },
            };

            var studentsWithFirstNameSmaller = GetStudentsWithFirstNameSmaller(students);

            foreach (var student in studentsWithFirstNameSmaller)
            {
                Console.WriteLine(student.FirstName);
                Console.WriteLine(student.LastName);
                Console.WriteLine();
            }
        }
    }
}
