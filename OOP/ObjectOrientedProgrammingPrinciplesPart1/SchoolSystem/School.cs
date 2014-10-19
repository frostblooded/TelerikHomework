
namespace SchoolSystem
{
    using System.Collections.Generic;

    public class School
    {
        private List<Class> classes;

        public List<Class> Classes
        {
            get
            {
                return new List<Class>(classes);
            }
            private set
            {
                classes = value;
            }
        }

        public School(List<Class> classes)
        {
            Classes = classes;
        }
    }
}
