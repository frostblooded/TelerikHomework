namespace SchoolSystem
{
    using System.Collections.Generic;

    public class Class
    {
        private List<Person> students;

        private List<Person> teachers;

        public Class()
        {
            Students = new List<Person>();
            Teachers = new List<Person>();
            TextID = "Unknown";
        }

        public Class(string textID)
            : this()
        {
            this.TextID = textID;
        }

        public Class(string textID, List<Person> students, List<Person> teachers)
            : this(textID)
        {
            this.Students = students;
            this.Teachers = teachers;
        }

        public List<Person> Students 
        { 
            get
            {
                return new List<Person>(students);
            }

            private set
            {
                students = value;
            }
        }

        public List<Person> Teachers 
        { 
            get
            {
                return new List<Person>(teachers);
            }

            private set
            {
                teachers = value;
            }
        }

        public string TextID { get; private set; }
    }
}
