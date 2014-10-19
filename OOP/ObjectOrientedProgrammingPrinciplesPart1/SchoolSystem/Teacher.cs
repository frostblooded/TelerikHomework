namespace SchoolSystem
{
    using System.Collections.Generic;

    public class Teacher : Person
    {
        public Teacher()
        {
            base.Disciplines = new List<Discipline>();
        }

        public Teacher(string name, List<Discipline> disciplines)
            :this()
        {
            base.Disciplines = disciplines;
            base.Name = name;
        }

        public override string ToString()
        {
            return string.Format("Teacher name: {0}", base.Name);
        }
    }
}
