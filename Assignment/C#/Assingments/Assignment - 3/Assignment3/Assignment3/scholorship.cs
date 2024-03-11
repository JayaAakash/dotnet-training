using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    public class Scholarship
    {
        public double Merit(int marks, double fees)
        {
            double scholarshipAmount = 0.0;

            if (marks >= 70 && marks <= 80)
            {
                scholarshipAmount = 0.20 * fees; 
            }
            else if (marks > 80 && marks <= 90)
            {
                scholarshipAmount = 0.30 * fees; 
            }
            else if (marks > 90)
            {
                scholarshipAmount = 0.50 * fees; 
            }

            return scholarshipAmount;
        }
    }

    class scholarship
    {
        static void Main(string[] args)
        {
            Scholarship scholarship = new Scholarship();

            int marks = 50;
            double fees = 10000.0;

            double scholarshipAmount = scholarship.Merit(marks, fees);

            Console.WriteLine($"Scholarship Amount: {scholarshipAmount}");
            Console.ReadLine();
        }
    }
}