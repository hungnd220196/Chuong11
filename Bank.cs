using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chuong11
{
    public class Bank
    {
        private List<Account> accounts = new List<Account>();
        private const int maxAccounts = 100;

        public void CreateAccount(string accountNumber, string accountName, double initialBalance)
        {
            if (accounts.Count >= maxAccounts)
            {
                Console.WriteLine("Account limit reached. Cannot create a new account.");
                return;
            }
            accounts.Add(new Account(accountNumber, accountName, initialBalance));
            Console.WriteLine("Account created successfully.");
        }

        public void Withdraw(string accountNumber, double amount)
        {
            Account account = accounts.Find(acc => acc.AccountNumber == accountNumber);
            if (account != null)
            {
                account.Withdraw(amount);
            }
            else
            {
                Console.WriteLine("Account not found.");
            }
        }

        public void Deposit(string accountNumber, double amount)
        {
            Account account = accounts.Find(acc => acc.AccountNumber == accountNumber);
            if (account != null)
            {
                account.Deposit(amount);
            }
            else
            {
                Console.WriteLine("Account not found.");
            }
        }

        public void Display()
        {
            foreach (var account in accounts)
            {
                if (account.AccountBalance > 100)
                {
                    Console.WriteLine(account);
                }
            }
        }
    }

}
