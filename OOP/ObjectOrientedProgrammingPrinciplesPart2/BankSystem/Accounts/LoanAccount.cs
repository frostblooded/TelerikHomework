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

        public override decimal CalculateInterest(int months)
        {
            if (CustomerType == CustomerType.Individual)
            {
                if (!FirstMonthsPassed(3))
                { 
                    months -= (DateTime.Now.Month - CreationTime.AddMonths(3).Month);
                }
            }
            else if (CustomerType == CustomerType.Company && FirstMonthsPassed(2))
            {
                months -= (DateTime.Now.Month - CreationTime.AddMonths(2).Month); ;
            }

            if (months < 0)
            {
                months = 0;
            }

            return Balance + Balance * months * InterestRate / 100;
        }
    }
}
