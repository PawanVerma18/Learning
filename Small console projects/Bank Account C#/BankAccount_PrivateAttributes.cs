using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp46
{
    internal class BankAccount
    {
        private String AccountNumber;
        private double Balance;

        public BankAccount(string a, double b)
        {
            AccountNumber = a;
            Balance = b;
        }

        public string GetAccountNumber()
        {
            return AccountNumber;
        }
        public double GetBalance()
        {
            return Balance;
        }
        public void deposit(double amount)
        {
            if(amount>0)
            {
                Balance = Balance + amount;
                Console.WriteLine($"Amount {amount} is credited successfully!");

            }
            else
            {
                Console.WriteLine("Invalid Amount!");
            }
            
        }

        public void withdrawal(double amount)
        {
            if(amount>0 && amount==Balance)
            {
                Balance = Balance - amount;
                Console.WriteLine($"Amount {amount} is debited successfully!");
            }
            else if (amount > Balance)
            {
                Console.WriteLine("Insufficient Balance!");
            }


            else
            {
                Console.WriteLine("Invalid Amount!");
            }
        }

    }

}
