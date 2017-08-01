using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    /// <summary>
    /// This represents a bank account
    /// </summary>
    public class Account
    {
        public Account()
        {

        }

        public Account(double initialBalance)
        {
            if (initialBalance < 0)
                throw new ArgumentException();
            Balance = initialBalance;
        }

        public double Balance
        {
            get; private set;
        }

        /// <summary>
        /// Adds an amount to the balance
        /// </summary>
        /// <param name="amt">The amount to be added</param>
        public void Deposit(double amt)
        {
            if(amt > 0)
            {
                Balance += amt;
            }
            else
            {
                throw new ArgumentException("Deposit amount must be a positive number.");
            }
        }

        /// <summary>
        /// Take money from account
        /// </summary>
        /// <param name="amt">The amount to be withdrawn</param>
        public void Withdraw(double amt)
        {
            if (amt < 0)
                throw new ArgumentException("Withdrawal amount cannot be negative.");
            else
                Balance -= amt;
        }
    }
}
