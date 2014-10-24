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

        private int CalculateMonths(int months)
        {
            if (Balance > 0 && Balance < 1000)
            {
                Console.WriteLine("There is no interest if your balance is below 1000!");
                months = 0;
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
