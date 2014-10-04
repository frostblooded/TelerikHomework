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
                new Student("Nikolay", "Danailov", "frostblooded@yahoo.com", "029584950", new List<int> { 6, 6, 5, 6, 4 }, "123407", 2, "Mathematics"),
                new Student("Anonio", "Mindov", "antonio.da@abv.bg", "039543456", new List<int> { 5, 4, 3, 2, 2 }, "345613", 3, "Chemistry"),
                new Student("Petar", "Petrov", "pesho@gmail.com", "024532367", new List<int> { 6, 6, 6, 6, 6 }, "231406", 4, "IT"),
                new Student("Histo", "Ezekiev", "histo@abv.bg", "144556234", new List<int> { 4, 5, 4, 2, 3, 2 }, "231206", 2, "Mathematics")
            };

            var studentsFromMath =
                from student in students
                where student.Group.DepartmentName == "Mathematics"
                select student;

            foreach (var student in studentsFromMath)
            {
                Console.WriteLine(student);
            }
        }
    }
}
