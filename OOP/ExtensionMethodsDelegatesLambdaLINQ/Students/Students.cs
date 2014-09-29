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
                new Student("Nikolay", "Danailov", 1, "frostblooded@yahoo.com", "029584950"),
                new Student("Anonio", "Mindov", 1, "antonio.da@abv.bg", "039543456"),
                new Student("Petar", "Petrov", 2, "pesho@gmail.com", "024532367"),
                new Student("Histo", "Ezekiev", 2, "histo@abv.bg", "144556234")
            };

            var studentsWithTelsFromSofia =
                from student in students
                where student.Tel.Substring(0, 2) == "02"
                select student;

            foreach (var student in studentsWithTelsFromSofia)
            {
                Console.WriteLine(student);
            }
        }
    }
}
