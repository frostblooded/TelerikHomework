using System;
namespace BankSystem
{
    public class DepositAccount : Account, IDepositable, IWithdrawable
    {
        public DepositAccount(decimal balance, Customer customer, CustomerType customerType, int interestRate, DateTime creationTime)
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

        public void Withdraw(decimal amount)
        {
            Balance -= amount;
        }

        public override decimal CalculateInterest(int months)
        {
            return Balance + ((months * InterestRate) / 100);
        }
    }
}
