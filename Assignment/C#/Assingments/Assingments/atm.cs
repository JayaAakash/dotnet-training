using System;


namespace Asssignments
{
    class Accounts
    {

        private int accountNo;
        private string customerName;
        private string accountType;
        private char transactionType;
        private double amount;
        private double balance;


        public Accounts(int accountNo, string customerName, string accountType, char transactionType, double amount)
        {
            this.accountNo = accountNo;
            this.customerName = customerName;
            this.accountType = accountType;
            this.transactionType = transactionType;
            this.amount = amount;
            this.balance = 0;
        }


        public void UpdateBalance()
        {
            if (transactionType == 'D')
            {
                Credit(amount);
            }
            else if (transactionType == 'W')
            {
                Debit(amount);
            }
            else
            {
                Console.WriteLine("Invalid transaction type");
            }
        }


        private void Credit(double amount)
        {
            balance += amount;
        }


        private void Debit(double amount)
        {
            if (balance >= amount)
            {
                balance -= amount;
            }
            else
            {
                Console.WriteLine("Insufficient balance");
            }
        }


        public void ShowData()
        {
            Console.WriteLine($"Account No: {accountNo}");
            Console.WriteLine($"Customer Name: {customerName}");
            Console.WriteLine($"Account Type: {accountType}");
            Console.WriteLine($"Transaction Type: {transactionType}");
            Console.WriteLine($"Amount: {amount}");
            Console.WriteLine($"Balance: {balance}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            Accounts account = new Accounts(1026758, "Bhanu", "Savings", 'W', 1000);


            account.UpdateBalance();


            account.ShowData();
        }
    }
}