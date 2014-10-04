using System;
using System.Collections.Generic;

namespace Students
{
    class Student
    {
        private string tel;

        public Student(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public Student(string firstName, string lastName, string email)
            :this(firstName, lastName)
        {
            this.Email = email;
        }

        public Student(string firstName, string lastName, string email, string tel)
            : this(firstName, lastName, email)
        {
            this.Tel = tel;
        }

        public Student(string firstName, string lastName, string email, string tel, List<int> marks)
            : this(firstName, lastName, email, tel)
        {
            this.Marks = marks;
        }

        public Student(string firstName, string lastName, string email, string tel, List<int> marks, string FN)
            : this(firstName, lastName, email, tel, marks)
        {
            this.FN = FN;
        }

        public Student(string firstName, string lastName, string email, string tel, List<int> marks, string FN, int groupNumber, string departmentName)
            : this(firstName, lastName, email, tel, marks, FN)
        {
            this.Group = new Group();
            this.Group.GroupNumber = groupNumber;
            this.Group.DepartmentName = departmentName;
        }

        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string FN { get; private set; }
        public string Tel 
        {
            get
            {
                return tel;
            }
            private set
            {
                if (value.Length < 9)
                {
                    throw new FormatException("The phone number isn't in the correct format");
                }
                else
                {
                    this.tel = value;
                }
            }
        }
        public string Email { get; set; }
        public List<int> Marks { get; set; }
        public Group Group { get; set; }

        public override string ToString()
        {
            return this.FirstName + " " + this.LastName;
        }
    }
}
