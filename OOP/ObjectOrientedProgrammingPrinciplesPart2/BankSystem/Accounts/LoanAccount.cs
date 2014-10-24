using System;

namespace BankSystem
{
    public class LoanAccount : Account, IDepositable
    {
        public LoanAccount(decimal balance, Customer customer, CustomerType customerType, int interestRate, DateTime creationTime)
        {
            Balance = balance;
            Customer = customer;
            CustomerType = customerType;
            InterestRate = interestRate;
            CreationTime = creationTime;
        }

        public void Deposit(decimal amount)
        {
            Balance += amount;
        }

        private int CalculateMonths(int months)
        {
            if (CustomerType == CustomerType.Individual)
            {
                if (!FirstMonthsPassed(3, DateTime.Now.AddMonths(months)))
                {
                    months = 0;
                    Console.WriteLine("There is no interest for the first 3 months!");
                }
                else
                {
                    months = DateTime.Now.Month - CreationTime.AddMonths(3).Month;
                }
            }
            else if (CustomerType == CustomerType.Company)
            {
                if (!FirstMonthsPassed(2, DateTime.Now.AddMonths(months)))
                {
                    months = 0;
                    Console.WriteLine("There is no interest for the first 2 months!");
                }
                else
                {
                    months = DateTime.Now.Month - CreationTime.AddMonths(2).Month;
                }
            }

            return months;
        }

        public override decimal CalculateInterest(int months)
        {
            months = CalculateMonths(months);
            return Balance + Balance * months * InterestRate / 100;
        }
    }
}
