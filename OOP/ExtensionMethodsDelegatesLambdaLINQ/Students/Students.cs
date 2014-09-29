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
                new Student("Nikolay", "Danailov", 1, "frostblooded@yahoo.com", "029584950", new List<int> { 6, 6, 5, 6, 4 }, "123407"),
                new Student("Anonio", "Mindov", 1, "antonio.da@abv.bg", "039543456", new List<int> { 5, 4, 3, 2, 2 }, "345613"),
                new Student("Petar", "Petrov", 2, "pesho@gmail.com", "024532367", new List<int> { 6, 6, 6, 6, 6 }, "231406"),
                new Student("Histo", "Ezekiev", 2, "histo@abv.bg", "144556234", new List<int> { 4, 5, 4, 2, 3, 2 }, "231206")
            };

            var studentsEnrolledIn2006 =
                from st in students
                where st.FN.Substring(4, 2) == "06"
                select new
                {
                    FullName = st.FirstName + " " + st.LastName,
                    Marks = st.Marks
                };

            foreach (var student in studentsEnrolledIn2006)
            {
                Console.Write("{0} - Marks: ", student.FullName);

                foreach (var mark in student.Marks)
                {
                    Console.Write(mark + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
