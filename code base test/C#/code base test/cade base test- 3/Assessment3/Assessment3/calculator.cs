using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment3
{
    public delegate int CalculatorDelegate(int x, int z);

    class Calculator
    {
        public static int Add(int x, int z)
        {
            return x + z;
        }

        public static int Subtract(int x, int z)
        {
            return x - z;
        }

        public static int Multiply(int x, int z)
        {
            return x * z;
        }
    }

    class calculator
    {
        static void Main(string[] args)
        {
            CalculatorDelegate addDelegate = new CalculatorDelegate(Calculator.Add);
            CalculatorDelegate subtractDelegate = new CalculatorDelegate(Calculator.Subtract);
            CalculatorDelegate multiplyDelegate = new CalculatorDelegate(Calculator.Multiply);

            Console.WriteLine("enter the numbers that operations like addition, substraction, mutliplication to perform:");
            Console.WriteLine("Enter your first number:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your second number:");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int sum = addDelegate(num1, num2);
            Console.WriteLine($"Sum: {sum}");

            int minus = subtractDelegate(num1, num2);
            Console.WriteLine($"Minus: {minus}");

            int multiply = multiplyDelegate(num1, num2);
            Console.WriteLine($"Multiply: {multiply}");

            Console.ReadLine();
        }
    }
}
