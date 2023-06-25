using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPrinciples.Encapsulation
{
    public class BankAccount
    {
        private string accountNumber;
        private decimal balance;
        private string ownerName;

        //Costructor
        public BankAccount(string accountNumber, decimal initialBalance, string ownerName)
        {
            this.accountNumber = accountNumber;
            this.balance = initialBalance;
            this.ownerName = ownerName;
        }

        public void Deposit(decimal amount)
        {
          
            balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            // Validation, logging 
            if (amount <= balance)
            {
                balance -= amount;
            }
            else
            {
                Console.WriteLine("Insufficient funds!");
            }
        }

        public decimal GetBalance()
        {
            // Perform any additional operations if needed
            return balance;
        }
    }
}
