using System.Collections.Generic;

namespace SchoolSystem
{
    public abstract class Person : INameable
    {
        private List<Discipline> _disciplines;

        public List<Discipline> Disciplines
        {
            get { return new List<Discipline>(_disciplines); }
            protected set { _disciplines = value; }
        }

        public string Name { get; protected set; }

        public abstract override string ToString();
    }
}