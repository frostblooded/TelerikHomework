using System.Collections.Generic;

namespace Students
{
    class Student
    {
        public Student(string firstName, string lastName, int groupNumber)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.GroupNumber = groupNumber;
        }

        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string FN { get; private set; }
        public string Tel { get; set; }
        public string Email { get; set; }
        public List<int> Marks { get; set; }
        public int GroupNumber { get; set; }

        public override string ToString()
        {
            return this.FirstName + " " + this.LastName + " " + this.GroupNumber;
        }
    }
}
