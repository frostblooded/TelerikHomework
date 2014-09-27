using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadCompanyInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the company's name?");
            string companyName = Console.ReadLine();
            Console.WriteLine("What is the company's address?");
            string companyAddress = Console.ReadLine();
            Console.WriteLine("What is the company's phone number?");
            string companyPhoneNumber = Console.ReadLine();
            Console.WriteLine("What is the company's fax number?");
            string companyFaxNumber = Console.ReadLine();
            Console.WriteLine("What is the company's web site?");
            string companyWebSite = Console.ReadLine();
            Console.WriteLine("What is the manager's first name?");
            string managerFirstName = Console.ReadLine();
            Console.WriteLine("What is the manager's last name?");
            string managerLastName = Console.ReadLine();
            Console.WriteLine("What is the manager's age?");
            int managerAge = int.Parse(Console.ReadLine());
            Console.WriteLine("What is the manager's phone number?");
            string managerPhoneNumber = Console.ReadLine();
            Console.WriteLine(@"
Company Name: {0}
Company Address: {1}
Company Phone Number: {2}
Company Fax Number: {3}
Company Web Site: {4}
Manager First Name: {5}
Manager Last Name: {6}
Manager Age: {7}
Manager Phone Number: {8}", companyName, companyAddress, companyPhoneNumber, companyFaxNumber, companyWebSite, managerFirstName, managerLastName, managerAge, managerPhoneNumber);
        }
    }
}
