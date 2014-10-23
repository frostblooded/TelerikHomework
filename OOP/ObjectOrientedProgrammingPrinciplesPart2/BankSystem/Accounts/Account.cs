using System;

namespace BankSystem
{
    public abstract class Account
    {
        private int interestRate;
        private Customer customer;

        public CustomerType CustomerType { get; set; }
        public Customer Customer
        { 
            get
            {
                return customer;
            }

            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("The entered customer can't be null!");
                }
                else
                {
                    customer = value;
                }
            }
        }
        public decimal Balance { get; set; }
        public int InterestRate
        {
            get
            {
                return interestRate;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The interest rate can't be negative!");
                }
                else
                {
                    interestRate = value;
                }
            }
        }
        public DateTime CreationTime { get; set; }

        protected bool FirstMonthsPassed(int months)
        {
            var monthsFromStartDate = CreationTime.AddMonths(months);
            return monthsFromStartDate < DateTime.Now;
        }

        public abstract decimal CalculateInterest(int months);
    }
}
