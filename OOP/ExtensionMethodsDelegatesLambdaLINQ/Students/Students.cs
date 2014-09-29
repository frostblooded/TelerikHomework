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
                new Student("Nikolay", "Danailov", 1),
                new Student("Anonio", "Mindov", 1),
                new Student("Petar", "Petrov", 2),
                new Student("Histo", "Ezekiev", 2)
            };

            var studentsFromSecondGroup = students.Where(st => st.GroupNumber == 2).OrderBy(st => st.FirstName);

            foreach (var student in studentsFromSecondGroup)
            {
                Console.WriteLine(student);
            }
        }
    }
}
