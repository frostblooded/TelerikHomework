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
            return Balance + ((months * InterestRate) / 100);
        }
    }
}
