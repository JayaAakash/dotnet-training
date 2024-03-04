using System;

namespace Asssignments
{
    class practice
    {
        public void Equal_numbers()
        {
            Console.WriteLine("enter your first number:-");
            int no1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter your second number:-");
            int no2 = Convert.ToInt32(Console.ReadLine());

            if (no1 == no2)
            {
                Console.WriteLine("the integers are equal");
            }

            else
            {
                Console.WriteLine("the integers are not equal");
            }
        }


        public void pos_neg_no()
        {
            Console.WriteLine("enter a numbers:-");
            int no = Convert.ToInt32(Console.ReadLine());

            if (no > 0)
            {
                Console.WriteLine("number is positive (+)");
            }
            else
            {
                Console.WriteLine("number is negative (-)");
            }
        }

        public void operation()
        {
            Console.WriteLine("enter the first number:-");
            double num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter the second number :-");
            double num2 = Convert.ToInt32(Console.ReadLine());

            double result = num1 - num2;
            Console.WriteLine($"The result of subtracting {num1} from {num2} is: {result}");
        }

        public void Multiplication()
        {
            Console.WriteLine("enter a number :-");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"multiplication of table [num]");
            for (int i = 1; i <= 10; i++)
            {
                int result = num * i;
                Console.WriteLine($"{num} x {i} = {result}");
            }
        }

        public void triple()
        {
            Console.WriteLine("Type first number:-");
            int no1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Type second number:-");
            int no2 = Convert.ToInt32(Console.ReadLine());

            int sum = no1 + no2;

            if (no1 == no2)
            {
                sum *= 3;

            }
            Console.WriteLine($"The sum of {sum}");
        }

        public void weekday()
        {
            Console.WriteLine("enter any number between 1 to 7 in order to check days:- ");
            int daynum = Convert.ToInt32(Console.ReadLine());

            string dayname;


            switch (daynum)
            {
                case 1:
                    dayname = "monday";
                    break;

                case 2:
                    dayname = "tuesday";
                    break;

                case 3:
                    dayname = "wednesday";
                    break;

                case 4:
                    dayname = "thurday";
                    break;

                case 5:
                    dayname = "friday";
                    break;

                case 6:
                    dayname = "saturday";
                    break;

                case 7:
                    dayname = "sunday";
                    break;

                default:
                    dayname = "invalid day number";
                    break;

                    Console.WriteLine($"the entered day is {dayname}");

            }


        }

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
                this.balance = 1100;
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

        class Student
        {

            private int rollNo;
            private string name;
            private string className;
            private string semester;
            private string branch;
            private int[] marks = new int[5];

            public Student(int rollNo, string name, string className, string semester, string branch)
            {
                this.rollNo = rollNo;
                this.name = name;
                this.className = className;
                this.semester = semester;
                this.branch = branch;
            }

            public void GetMarks()
            {
                Console.WriteLine("Enter marks for 5 subjects:");
                for (int i = 0; i < 5; i++)
                {
                    Console.Write($"Subject {i + 1}: ");
                    marks[i] = Convert.ToInt32(Console.ReadLine());
                }
            }

            public void DisplayResult()
            {
                double average = CalculateAverage();

                Console.WriteLine($"Average marks: {average}");

                bool isFailed = false;
                foreach (int mark in marks)
                {
                    if (mark < 35)
                    {
                        isFailed = true;
                        break;
                    }
                }

                if (isFailed || (average < 45))
                {
                    Console.WriteLine("Result: Failed");
                }
                else
                {
                    Console.WriteLine("Result: Passed");
                }
            }


            private double CalculateAverage()
            {
                double sum = 0;
                foreach (int mark in marks)
                {
                    sum += mark;
                }
                return sum / marks.Length;
            }

            public void DisplayData()
            {
                Console.WriteLine($"Roll No: {rollNo}");
                Console.WriteLine($"Name: {name}");
                Console.WriteLine($"Class: {className}");
                Console.WriteLine($"Semester: {semester}");
                Console.WriteLine($"Branch: {branch}");
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine($"Subject {i + 1}: {marks[i]}");
                }
            }
        }

        static void Main()
        {
            Student student = new Student(011, "Bhanu", "10th", "mid", "Computer Science");
            Console.WriteLine("----------------Student Marks----------------------");

            student.GetMarks();
            student.DisplayResult();
            student.DisplayData();


            Accounts account = new Accounts(1026758, "Bhanu", "Savings", 'W', 1000);
            Console.WriteLine("----------------ATM----------------------");

            account.UpdateBalance();
            account.ShowData();

            practice ps = new practice();
            Console.WriteLine("PRACTICE SESSION");
            Console.WriteLine("1)----------Equal number or not program output--------------");
            Console.WriteLine();
            ps.Equal_numbers();
            Console.WriteLine();
            Console.WriteLine("2)----------positive and negative program output--------------");
            Console.WriteLine();
            ps.pos_neg_no();
            Console.WriteLine();
            Console.WriteLine("3)----------operations program output--------------");
            Console.WriteLine();
            ps.operation();
            Console.WriteLine();
            Console.WriteLine("4)----------Multiplication program output--------------");
            Console.WriteLine();
            ps.Multiplication();
            Console.WriteLine("5) ---------Triple sum program output-------------------");
            Console.WriteLine();
            ps.triple();
            Console.WriteLine();
            Console.WriteLine("6)------------------weekday program output-----------------");
            Console.WriteLine();
            ps.weekday();
            Console.Read();

        }
    }
}

