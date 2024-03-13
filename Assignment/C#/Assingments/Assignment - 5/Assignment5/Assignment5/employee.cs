using System;

namespace Assignment5
{
    public class Employee
    {
        public int Empid { get; set; }
        public string Empname { get; set; }
        public float Empsalary { get; set; }

        public Employee(int empid, string empname, float empsalary)
        {
            Empid = empid;
            Empname = empname;
            Empsalary = empsalary;
        }

        public virtual void DisplayDetails()
        {
            Console.WriteLine($"Employee ID: {Empid}");
            Console.WriteLine($"Employee Name: {Empname}");
            Console.WriteLine($"Employee Salary: {Empsalary}");
        }
    }

    public class ParttimeEmployee : Employee
    {
        public float Wages { get; set; }

        public ParttimeEmployee(int empid, string empname, float empsalary, float wages) : base(empid, empname, empsalary)
        {
            Wages = wages;
        }

        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"Wages: {Wages}");
        }
    }

    public class employee
    {
        public static void Main()
        {
            ParttimeEmployee parttimeEmployee = new ParttimeEmployee(001, "Banu Rekha", 50000, 20);

            parttimeEmployee.DisplayDetails();
            Console.ReadLine();
        }
    }
}
