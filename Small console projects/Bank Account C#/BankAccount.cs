using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp41
{
    public class BankAccount
    {
         public decimal AccountBalance;
        public BankAccount()
        {
            AccountBalance = 0;
        }

        public void deposit(int amount)
        {
            if (amount <= 3000)
            {
                if (amount > 0)
                {
                    AccountBalance = AccountBalance + amount;
                    Console.WriteLine($"Amount {amount} is added in your BankAccount successfully!");
                }

                else
                {
                    Console.WriteLine("Invalid Amount Deposit!");
                }
            }
            else
            {
                Console.WriteLine("Sorry,more than 3000 cannot be deposited!");
            }
            
        }

        public void withdrawal(int amount)
        {
            if (AccountBalance == 0)
            {
                Console.WriteLine("Sorry,your AccountBalance is zero(0)!");
            }
            else
            {
                if (amount > 0 && amount <= AccountBalance)
                {
                    AccountBalance = AccountBalance - amount;
                    Console.WriteLine($"Amount {amount} is deducted from your BankAcccount successfully!");
                }
                else
                {
                    Console.WriteLine("Not enough money in your BankAccount to withdraw!");
                }

            }

        }
    }
    
}
