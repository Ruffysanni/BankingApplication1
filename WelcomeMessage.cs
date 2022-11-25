using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BankingApplication1
{
    public class WelcomeMessage
    {
        public class UserId
        {
            public string Name { get; set; }
            public string Surname { get; set; }
            public string Email { get; set; }
            public string Password { get; set; }
            public string TransactionPin { get; set; }

            public string SavingsAcct { get; set; }
            public string CurrentAcct { get; set; }

            public UserId(string name, string surname, string email, string password)
            {
                Name = name;
                Surname = surname;
                Email = email;
                Password = password;
            }
        }

        public void Message()
        {
            Console.WriteLine("HURRAY!!! This is Noodles Banking...");
            Console.WriteLine();
            Console.WriteLine($"Press 0 to proceed as an existing user OR Press 1 to continue as new user.");

            string keyNumber = Console.ReadLine();
            if (keyNumber != "0")
            {
                Console.WriteLine("Invalid entry!!! Press 0.");
            }
            else
            {
                AccountInfo();
            }

        }

        public void AccountInfo()
        {
            Console.WriteLine("Enter your firstname: ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter your surname: ");
            string surname = Console.ReadLine();

            //Console.WriteLine("Enter your email: ");
            //string email = Console.ReadLine();

            //second email validation
            string email;
            bool isValidEmail;
            do
            {
                Console.WriteLine("Enter Email: ");
                email = Console.ReadLine();
                isValidEmail = IsValid( email);
                

                if (!isValidEmail)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Not a valid email address. Please retry!");
                    Console.ResetColor();
                }
            }
            while (!isValidEmail);

            Console.WriteLine("Enter your password: ");
            string password = Console.ReadLine();

            Console.WriteLine("Enter your Account Number: ");
            string accountNo = Console.ReadLine();

            Console.WriteLine($"You are welcome {name} {surname}. Your account number {accountNo} has a balance of ");
        }

        private static bool IsValid(string email)
        {
            string regex = @"^[^@\s]+@[^@\s]+\.(com|net|org|gov)$";

            return Regex.IsMatch(email, regex, RegexOptions.IgnoreCase);
        }

    }  
}
