namespace SchoolSystem
{
    using System.Collections.Generic;

    public class Class
    {
        List<Student> students;

        List<Teacher> teachers;

        List<Student> Students 
        { 
            get
            {
                return new List<Student>(students);
            }

            private set
            {
                students = value;
            }
        }

        List<Teacher> Teachers 
        { 
            get
            {
                return new List<Teacher>(teachers);
            }

            private set
            {
                teachers = value;
            }
        }

        public Class()
        {
            Students = new List<Student>();
            Teachers = new List<Teacher>();
        }
    }
}
