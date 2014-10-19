namespace SchoolSystem
{
    using System.Collections.Generic;
    using System;

    class SchoolSystem
    {
        static void Main()
        {
            Teacher basheva = new Teacher("Basheva", new List<Discipline>
            {
                new Discipline("Poluprovodnikovi Elementi", 2, 2),
            });

            Student me = new Student("Nikolay", new List<Discipline>() 
            { 
                new Discipline("Poluprovodnikovi Elementi", 2, 2), 
                new Discipline("Matematika", 2, 2), 
                new Discipline("Programirane", 2, 2), 
                new Discipline("Biologiq", 2, 2)
            }, "21");

            Class myClass = new Class("10a", new List<Person> { me }, new List<Person> { basheva });

            foreach (var t in myClass.Teachers)
            {
                Console.WriteLine(t);
            }

            Console.WriteLine();

            foreach (var st in myClass.Students)
            {
                Console.WriteLine(st);
            }
        }
    }
}
