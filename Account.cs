using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chuong11
{

    public class Account
    {
        public string AccountNumber { get; set; }
        public string AccountName { get; set; }
        public double AccountBalance { get; set; }

        public Account(string accountNumber, string accountName, double accountBalance)
        {
            AccountNumber = accountNumber;
            AccountName = accountName;
            AccountBalance = accountBalance; 
        }

        public void Deposit(double amount)
        {
            AccountBalance += amount;
            Console.WriteLine($"{amount} has been deposited. New Balance: {AccountBalance}");
        }

        public void Withdraw(double amount)
        {
            if (amount > AccountBalance)
            {
                Console.WriteLine("Insufficient funds.");
            }
            else
            {
                AccountBalance -= amount;
                Console.WriteLine($"{amount} has been withdrawn. New Balance: {AccountBalance}");
            }
        }

        public override string ToString()
        {
            return $"Account Number: {AccountNumber}, Account Name: {AccountName}, Balance: {AccountBalance}";
        }
    }

}
