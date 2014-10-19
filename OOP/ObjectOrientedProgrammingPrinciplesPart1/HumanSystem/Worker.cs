using System;

namespace HumanSystem
{
    public class Worker : Human
    {
        private int _weekSalary;
        private int _workHoursPerDay;

        public Worker(string firstName, string secondName, int weekSalary, int workHoursPerDay)
        {
            WeekSalary = weekSalary;
            WorkHoursPerDay = workHoursPerDay;
            FirstName = firstName;
            SecondName = secondName;
        }

        public int WeekSalary
        {
            get { return _weekSalary; }
            set
            {
                if (value >= 0)
                {
                    _weekSalary = value;
                }
                else
                {
                    Console.WriteLine("The salary can't be a negative value!");
                }
            }
        }

        public int WorkHoursPerDay
        {
            get { return _workHoursPerDay; }
            set
            {
                if (value >= 0)
                {
                    _workHoursPerDay = value;
                }
                else
                {
                    Console.WriteLine("The work hours can't be a negative value!");
                }
            }
        }

        public int MoneyPerHour()
        {
            return WeekSalary/5/WorkHoursPerDay;
        }

        public override string ToString()
        {
            return FirstName + " " + SecondName + " (Money Per Hour: " + MoneyPerHour() + ")";
        }
    }
}