using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_2_Bank_Account
{
    class Account
    {
        private string username;
        public double balance; 

        public Account(string username, double balance)
        {
            this.username = username;
            this.balance = balance;
        }
        public double CheckBalance()
        {
            return balance;
        }
        public double WithdrawMoney(double MoneyOut)
        {
            if (MoneyOut > balance)
            {
                Console.WriteLine("Poor lol");
            }
            else if (MoneyOut > 0)
            {
                Console.WriteLine("Withdraw Successful");
                balance = balance - MoneyOut;
            }
            else
            {
                Console.WriteLine("Negative Numbers!");
            }
            return balance;
        }
        public double DepositMoney(double MoneyIn)
        {
            if (MoneyIn > 0)
            {
                Console.WriteLine("Deposit Successful, Money added");
                balance = balance + MoneyIn;
            }
            else
            {
                Console.WriteLine("Deposit Error, Scam attempt");
            }
            return balance;
        }
        // Interest in format 1.05
        public double AddInterest(double InterestRate) 
        {
            string date = DateTime.Now.ToShortDateString();
            Console.WriteLine(date);
            if (date == "12/01/2021")
            {
                balance = balance * InterestRate;
            }
            return balance;
        }
    }
}
