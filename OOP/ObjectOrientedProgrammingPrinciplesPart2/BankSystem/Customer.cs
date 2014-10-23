using System;
namespace BankSystem
{
    public class Customer
    {
        public Customer()
        {
            FirstName = "Unknown";
            LastName = "Unknown";
            PhoneNumber = "Unknown";
        }

        public Customer(string firstName, string lastName, string phoneNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            PhoneNumber = phoneNumber;
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string PhoneNumber { get; set; }
    }
}
