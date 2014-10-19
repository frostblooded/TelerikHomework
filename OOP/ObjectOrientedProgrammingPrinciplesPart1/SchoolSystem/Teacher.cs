using System.Collections.Generic;

namespace SchoolSystem
{
    public class Teacher : Person
    {
        public Teacher()
        {
            Disciplines = new List<Discipline>();
        }

        public Teacher(string name, List<Discipline> disciplines)
            : this()
        {
            Disciplines = disciplines;
            Name = name;
        }

        public override string ToString()
        {
            return string.Format("Teacher name: {0}", Name);
        }
    }
}