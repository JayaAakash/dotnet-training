using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    public class InsufficientBalanceException : ApplicationException
    {
        public InsufficientBalanceException(string message) : base(message)
        {
        }
    }

    // BankAccount class with deposit, withdraw, and balance methods
    public class BankAccount
    {
        private double balance;

        public BankAccount(double initialBalance)
        {
            balance = initialBalance;
        }

        public void Deposit(double amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Deposit amount must be positive.");
            }
            balance += amount;
            Console.WriteLine($"Deposit of {amount:C} successful. Current balance: {balance:C}");
        }

        public void Withdraw(double amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Withdrawal amount must be positive.");
            }
            if (amount > balance)
            {
                throw new InsufficientBalanceException("Insufficient balance for withdrawal.");
            }
            balance -= amount;
            Console.WriteLine($"Withdrawal of {amount:C} successful. Current balance: {balance:C}");
        }

        public void CheckBalance()
        {
            Console.WriteLine($"Current balance: {balance:C}");
        }
    }

    class bank
    {
        static void Main(string[] args)
        {
            try
            {
                BankAccount account = new BankAccount(1000.0);

                account.Deposit(2000);
                account.Withdraw(1000);
                account.CheckBalance();
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Argument exception: {ex.Message}");
            }
            catch (InsufficientBalanceException ex)
            {
                Console.WriteLine($"Insufficient balance exception: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
            }
            Console.ReadLine();
        }
    }
}