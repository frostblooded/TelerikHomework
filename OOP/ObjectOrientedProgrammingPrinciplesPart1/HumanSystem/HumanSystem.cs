using System;
using System.Collections.Generic;
using System.Linq;

namespace HumanSystem
{
    internal class HumanSystem
    {
        private static void Main()
        {
            var students = new List<Student>
            {
                new Student("Pesho", "Petrov", 6),
                new Student("Ivan", "Asenov", 4),
                new Student("Nikolay", "Danailov", 5),
                new Student("Nikolay", "Milanov", 3),
                new Student("Dartel", "Pavlov", 1),
                new Student("Ivan", "Sashov", 6),
                new Student("Tetra", "Ase", 5),
                new Student("DSA", "Nhe", 5),
                new Student("ASD", "Dsa", 3),
                new Student("Petrov", "Ert", 5)
            };

            var workers = new List<Worker>
            {
                new Worker("Valeri", "Elenkov", 140, 8),
                new Worker("Peshov", "Petrov", 300, 6),
                new Worker("Ivan", "Petrov", 90, 12),
                new Worker("Semil", "Slozev", 170, 8),
                new Worker("Ilian", "Nikolaev", 210, 8),
                new Worker("Vasil", "Ivanov", 230, 6),
                new Worker("Damana", "Setrova", 270, 10),
                new Worker("Isk", "Golem", 280, 8),
                new Worker("Water", "Elemental", 290, 12),
                new Worker("Molten", "Giant", 235, 8)
            };

            var sortedStudents =
                from st in students
                orderby st.Grade
                select st;

            var sortedWorkers =
                from worker in workers
                orderby worker.MoneyPerHour() descending
                select worker;

            Console.WriteLine("Sorted students:");
            Console.WriteLine();

            foreach (var student in sortedStudents)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine();
            Console.WriteLine("Sorted Workers:");
            Console.WriteLine();

            foreach (var worker in sortedWorkers)
            {
                Console.WriteLine(worker);
            }

            var mergedList = new List<Human>(students).Union(new List<Human>(workers));
            var sortedMergedList =
                from human in mergedList
                orderby human.FirstName, human.SecondName
                select human;

            Console.WriteLine();
            Console.WriteLine("All humans:");
            Console.WriteLine();

            foreach (var human in sortedMergedList)
            {
                Console.WriteLine(human);
            }
        }
    }
}