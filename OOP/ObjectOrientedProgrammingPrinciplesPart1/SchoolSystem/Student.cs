namespace SchoolSystem
{
    using System.Collections.Generic;
    using System;

    public class Student : Person
    {
        public string ClassID { get; private set; }

        public Student(string name)
        {
            base.Name = name;
            ClassID = "Unknown";
            base.Disciplines = new List<Discipline>();
        }

        public Student(string name, List<Discipline> disciplines, string classID)
            :this(name)
        {
            base.Disciplines = disciplines;
            this.ClassID = classID;
        }

        public override string ToString()
        {
            return string.Format("Student name: {0}" + Environment.NewLine + "Class ID: {1}", base.Name, this.ClassID);
        }
    }
}
