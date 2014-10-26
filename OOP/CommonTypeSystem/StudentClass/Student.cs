using System;
using System.Collections.Generic;
namespace StudentClass
{
    public class Student
    {
        public Student(string firstName, string middleName, string lastName, string mobilePhone)
        {
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
            MobilePhone = mobilePhone;
        }

        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string SSN { get; set; }
        public string PermanentAddress { get; set; }
        public string MobilePhone { get; set; }
        public string Email { get; set; }
        public string Course { get; set; }
        public string Specialty { get; set; }
        public string University { get; set; }
        public List<string> Faculties { get; set; }

        public override bool Equals(object obj)
        {
            if (!(obj is Student))
            {
                throw new ArgumentException();
            }
            else
            {
                Student otherStudent = obj as Student;

                if (FirstName == otherStudent.FirstName && MiddleName == otherStudent.MiddleName && LastName == otherStudent.LastName && MobilePhone == otherStudent.MobilePhone)
                {
                    return true;
                }

                return false;
            }
        }

        public override string ToString()
        {
            return FirstName + " " + MiddleName + " " + LastName + " " + MobilePhone;
        }

        public override int GetHashCode()
        {
            return FirstName.GetHashCode() + MiddleName.GetHashCode() / LastName.GetHashCode();
        }

        public static bool operator ==(Student first, Student second)
        {
            return first.Equals(second);
        }

        public static bool operator !=(Student first, Student second)
        {
            return !first.Equals(second);
        }
    }
}
