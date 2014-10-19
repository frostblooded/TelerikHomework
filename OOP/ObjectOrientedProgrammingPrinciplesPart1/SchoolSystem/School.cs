using System.Collections.Generic;

namespace SchoolSystem
{
    public class School
    {
        private List<Class> _classes;

        public School(List<Class> classes)
        {
            Classes = classes;
        }

        public List<Class> Classes
        {
            get { return new List<Class>(_classes); }
            private set { _classes = value; }
        }
    }
}