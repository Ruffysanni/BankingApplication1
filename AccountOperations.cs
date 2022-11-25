using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BankingApplication1
{
    public class AccountOperations
    {
        public double Balance;
        public AccountOperations()
        {
            Balance = 1000.00;
        }

        //Menu Method...


        //A customer should be able to deposit money into his account.
        public double Deposit()
        {
            double NewBalance;
            double deposit;

            Console.WriteLine($"Please enter amount to deposit");
            deposit = double.Parse(Console.ReadLine());
            NewBalance = Balance + deposit;

            return NewBalance;
        }


        //A customer should be able to withdraw money from his account.
        public double Withdrawal()
        {
            double NewBalance;
            double withdrawal;

            Console.WriteLine($"Enter amount to withdraw: ");
            withdrawal = double.Parse(Console.ReadLine());
            NewBalance = Balance - withdrawal;
            if(withdrawal <= Balance)
            {
                return 0;
            }
            return NewBalance;
        }

        //A customer should be able to get the balance of a particular account.
        public void GetAccountBalance()
        {
            
        }

        //Log out of account
        public void LogOut()
        {
            Console.WriteLine($"You have successfully logged out of the system.");
        }
    }
}
