namespace SchoolSystem
{
    using System.Collections.Generic;

    public class Teacher : IPerson
    {
        List<Discipline> disciplines;

        public string Name { get; private set; }

        public List<Discipline> Disciplines
        {
            get
            {
                return new List<Discipline>(disciplines);
            }
            private set
            {
                disciplines = value;
            }
        }

        public Teacher()
        {
            Disciplines = new List<Discipline>();
        }
    }
}
