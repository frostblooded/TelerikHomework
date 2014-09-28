using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentsWithFirstNameSmallerThanLast
{
    class StudentsWithFirstNameSmallerThanLast
    {
        static IEnumerable<Student> GetStudentsWithFirstNameSmaller(Student[] students)
        {
            var comparedStudents = 
                from student in students
                where student.FirstName.CompareTo(student.LastName) < 0
                select student;
            return comparedStudents;
        }

        static IEnumerable<Student> GetStudentsBetween18And24(Student[] students)
        {
            var studentsWithAgeWithingRange =
                from student in students
                where student.Age >= 18 && student.Age <= 24
                select student;
            return studentsWithAgeWithingRange;
        }

        static IEnumerable<Student> SortStudentsByFirstAndThenByLastName(Student[] students)
        {
            var sortedStudents =
                from student in students
                orderby student.FirstName, student.LastName
                select student;
            return sortedStudents;
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
                    FirstName = "Petar",
                    LastName = "Petrov",
                    Age = 25
                },

                new Student
                {
                    FirstName = "Georgi",
                    LastName = "Danchev",
                    Age = 20
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
            Console.WriteLine();
            Console.WriteLine("All students sorted by name (with extension methods)");
            students.OrderBy(st => st.FirstName).ThenBy(st => st.LastName).ForEach(Console.WriteLine);
            Console.WriteLine();
            Console.WriteLine("All students sorted by name (with LINQ):");
            SortStudentsByFirstAndThenByLastName(students).ForEach(Console.WriteLine);
        }
    }
}
