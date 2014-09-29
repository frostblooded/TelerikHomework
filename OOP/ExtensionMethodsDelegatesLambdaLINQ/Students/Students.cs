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
                new Student("Nikolay", "Danailov", 1, "frostblooded@yahoo.com"),
                new Student("Anonio", "Mindov", 1, "antonio.da@abv.bg"),
                new Student("Petar", "Petrov", 2, "pesho@gmail.com"),
                new Student("Histo", "Ezekiev", 2, "histo@abv.bg")
            };

            var studentsWithEmailInAbvBg =
                from student in students
                where student.Email.Substring(student.Email.IndexOf('@') + 1) == "abv.bg"
                select student;

            foreach (var student in studentsWithEmailInAbvBg)
            {
                Console.WriteLine(student);
            }
        }
    }
}
