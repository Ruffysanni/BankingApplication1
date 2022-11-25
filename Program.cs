using System;
using System.Xml.Linq;

namespace BankingApplication1
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            WelcomeMessage welcomeMessage = new WelcomeMessage();
            welcomeMessage.Message();


            MenuClass menuClass = new MenuClass();
            //menuClass.OptionsMenu();

            

            AccountOperations account = new AccountOperations(); 
            
            GenerateAccountNumber genAcctNo = new();
            string savingsAcct = genAcctNo.SavingsAccountNumber();
            string currentAcct = genAcctNo.CurrentAccountNumber();
            Console.WriteLine(savingsAcct);
            Console.WriteLine(currentAcct);


            Console.WriteLine();
             
           
            

            double NewBalance;
            string balance;
            balance = Console.ReadLine();
            if(balance == "d")
            {
                NewBalance = account.Deposit();
                Console.WriteLine($"Your new account balance is {NewBalance}.");
            }

            if(balance == "w")
            {
                NewBalance = account.Withdrawal();
                Console.WriteLine($"Your new account balance is {NewBalance}.");
            }

            Console.WriteLine($"Your current balance is {account.Balance}.");
        }

    }
}
