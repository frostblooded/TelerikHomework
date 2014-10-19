using System;
using System.Collections.Generic;

namespace SchoolSystem
{
    internal class SchoolSystem
    {
        private static void Main()
        {
            var basheva = new Teacher("Basheva", new List<Discipline>
            {
                new Discipline("Poluprovodnikovi Elementi", 2, 2),
            });

            var me = new Student("Nikolay", new List<Discipline>
            {
                new Discipline("Poluprovodnikovi Elementi", 2, 2),
                new Discipline("Matematika", 2, 2),
                new Discipline("Programirane", 2, 2),
                new Discipline("Biologiq", 2, 2)
            }, "21");

            var myClass = new Class("10a", new List<Person> {me}, new List<Person> {basheva});

            foreach (Person t in myClass.Teachers)
            {
                Console.WriteLine(t);
            }

            Console.WriteLine();

            foreach (Person st in myClass.Students)
            {
                Console.WriteLine(st);
            }
        }
    }
}