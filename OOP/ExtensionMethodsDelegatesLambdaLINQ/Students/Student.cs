using System;
using System.Collections.Generic;

namespace Students
{
    class Student
    {
        private string tel;

        public Student(string firstName, string lastName, int groupNumber)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.GroupNumber = groupNumber;
        }

        public Student(string firstName, string lastName, int groupNumber, string email)
            :this(firstName, lastName, groupNumber)
        {
            this.Email = email;
        }

        public Student(string firstName, string lastName, int groupNumber, string email, string tel)
            : this(firstName, lastName, groupNumber, email)
        {
            this.Tel = tel;
        }

        public Student(string firstName, string lastName, int groupNumber, string email, string tel, List<int> marks)
            : this(firstName, lastName, groupNumber, email, tel)
        {
            this.Marks = marks;
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
        public int GroupNumber { get; set; }

        public override string ToString()
        {
            return this.FirstName + " " + this.LastName + " " + this.GroupNumber;
        }
    }
}
