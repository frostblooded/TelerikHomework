namespace SchoolSystem
{
    using System.Collections.Generic;

    public class Student : IPerson
    {
        List<Discipline> disciplines;

        public string Name { get; private set; }

        public string ClassID { get; private set; }

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
    }
}
