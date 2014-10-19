namespace SchoolSystem
{
    using System.Collections.Generic;

    public abstract class Person : INameable
    {
        private List<Discipline> disciplines;

        public string Name { get; protected set; }

        public List<Discipline> Disciplines
        {
            get
            {
                return new List<Discipline>(disciplines);
            }
            protected set
            {
                disciplines = value;
            }
        }

        public abstract override string ToString();
    }
}
