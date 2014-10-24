using System;

namespace BankSystem
{
    class BankSystem
    {
        static void Main()
        {
            var loan = new MortgageAccount(100M, new Customer("Nikolay", "Danailov", "0897850537"), CustomerType.Company, 10, new DateTime(2014, 8, 3));
            Console.WriteLine(loan.CalculateInterest(8));
        }
    }
}
