using System;

namespace BankSystem
{
    public class MortgageAccount : Account, IDepositable
    {
        public MortgageAccount(decimal balance, Customer customer, CustomerType customerType, int interestRate, DateTime creationTime)
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

        public override decimal CalculateInterest(int months)
        {
            int halfMonths = 0, fullMonths = 0;

            if (CustomerType == CustomerType.Individual)
            {
                halfMonths = ((DateTime.Now.AddMonths(months).Year - CreationTime.Year) * 12) + DateTime.Now.AddMonths(months).Month - CreationTime.Month;

                if (halfMonths > 6)
                {
                    halfMonths = 6;
                }

                if (FirstMonthsPassed(6, DateTime.Now.AddMonths(months)))
                {
                    fullMonths = DateTime.Now.AddMonths(months).Month - CreationTime.AddMonths(6).Month;
                }
            }
            else if (CustomerType == CustomerType.Company)
            {
                halfMonths = ((DateTime.Now.AddMonths(months).Year - CreationTime.Year) * 12) + DateTime.Now.AddMonths(months).Month - CreationTime.Month;

                if (halfMonths > 12)
                {
                    halfMonths = 12;
                }

                if (FirstMonthsPassed(12, DateTime.Now.AddMonths(months)))
                {
                    fullMonths = DateTime.Now.AddMonths(months).Month - CreationTime.AddMonths(12).Month;
                }
            }

            return Balance + (Balance * halfMonths * InterestRate / 2 / 100) + (Balance * fullMonths * InterestRate / 100);
        }
    }
}
