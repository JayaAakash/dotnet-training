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


       static void main()
        { 
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

