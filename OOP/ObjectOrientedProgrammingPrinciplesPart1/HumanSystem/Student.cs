using System;

namespace HumanSystem
{
    public class Student : Human
    {
        private int _grade;

        public Student(string firstName, string secondName, int grade)
        {
            Grade = grade;
            FirstName = firstName;
            SecondName = secondName;
        }

        public int Grade
        {
            get { return _grade; }
            set
            {
                if (value > 6 || value < 1)
                {
                    Console.WriteLine("The grade isn't in the valid range (1 - 6)");
                }
                else
                {
                    _grade = value;
                }
            }
        }

        public override string ToString()
        {
            return FirstName + " " + SecondName + " " + " (Grade: " + Grade.ToString() + ")";
        }
    }
}