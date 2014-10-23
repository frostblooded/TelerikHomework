using System;

namespace BankSystem
{
    class BankSystem
    {
        static void Main()
        {
            var loan = new LoanAccount(20.20M, new Customer("Nikolay", "Danailov", "0897850537"), CustomerType.Individual, 10, new DateTime(2014, 6, 3));
            Console.WriteLine(loan.CalculateInterest(4));
        }
    }
}
