using System;
using System.Collections.Generic;

namespace SchoolSystem
{
    public class Student : Person
    {
        public Student(string name)
        {
            Name = name;
            ClassId = "Unknown";
            Disciplines = new List<Discipline>();
        }

        public Student(string name, List<Discipline> disciplines, string classId)
            : this(name)
        {
            Disciplines = disciplines;
            ClassId = classId;
        }

        public string ClassId { get; private set; }

        public override string ToString()
        {
            return string.Format("Student name: {0}" + Environment.NewLine + "Class ID: {1}", Name, ClassId);
        }
    }
}