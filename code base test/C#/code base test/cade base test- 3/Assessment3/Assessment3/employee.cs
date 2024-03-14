using System;
using System.Collections.Generic;
using System.Linq;

namespace Assessment3
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public DateTime DOB { get; set; }
        public DateTime DOJ { get; set; }
        public string City { get; set; }

        public Employee(int id, string firstName, string lastName, string title, DateTime dob, DateTime doj, string city)
        {
            EmployeeID = id;
            FirstName = firstName;
            LastName = lastName;
            Title = title;
            DOB = dob;
            DOJ = doj;
            City = city;
        }

        public override string ToString()
        {
            return $"EmployeeID: {EmployeeID}, Name: {FirstName} {LastName}, Title: {Title}, DOB: {DOB.ToShortDateString()}, DOJ: {DOJ.ToShortDateString()}, City: {City}";
        }
    }
    class employee
    {
        static void Main(string[] args)
        {
            List<Employee> empList = new List<Employee>();

            empList.Add(new Employee(1001, "Malcolm", "Daruwalla", "Manager", new DateTime(1984, 11, 16), new DateTime(2011, 6, 8), "Mumbai"));
            empList.Add(new Employee(1002, "Asdin", "Dhalla", "AsstManager", new DateTime(1984, 8, 20), new DateTime(2012, 7, 7), "Mumbai"));
            empList.Add(new Employee(1003, "Madhavi", "Oza", "Consultant", new DateTime(1987, 11, 14), new DateTime(2015, 4, 12), "Pune"));
            empList.Add(new Employee(1004, "Saba", "Shaikh", "SE", new DateTime(1990, 6, 3), new DateTime(2016, 2, 2), "Pune"));
            empList.Add(new Employee(1005, "Nazia", "Shaikh", "SE", new DateTime(1991, 3, 8), new DateTime(2016, 2, 2), "Mumbai"));
            empList.Add(new Employee(1006, "Amit", "Pathak", "Consultant", new DateTime(1989, 11, 7), new DateTime(2014, 8, 8), "Chennai"));
            empList.Add(new Employee(1007, "Vijay", "Natrajan", "Consultant", new DateTime(1989, 12, 2), new DateTime(2015, 1, 6), "Mumbai"));
            empList.Add(new Employee(1008, "Rahul", "Dubey", "Associate", new DateTime(1993, 11, 11), new DateTime(2014, 6, 11), "Chennai"));
            empList.Add(new Employee(1009, "Suresh", "Mistry", "Associate", new DateTime(1992, 8, 12), new DateTime(2014, 3, 12), "Chennai"));
            empList.Add(new Employee(1010, "Sumit", "Shah", "Manager", new DateTime(1991, 4, 12), new DateTime(2016, 2, 1), "Pune"));



            var allEmployees = empList.Select(e => e);
            Console.WriteLine("All Employees:");
            foreach (var emp in allEmployees)
            {
                Console.WriteLine(emp);
            }

            var employeesNotInMumbai = empList.Where(e => e.City != "Mumbai");
            Console.WriteLine("\nEmployees not in Mumbai:");
            foreach (var emp in employeesNotInMumbai)
            {
                Console.WriteLine(emp);
            }

            var asstManagers = empList.Where(e => e.Title == "AsstManager");
            Console.WriteLine("\nAsst Managers:");
            foreach (var emp in asstManagers)
            {
                Console.WriteLine(emp);
            }

            var employeesWithLastNameS = empList.Where(e => e.LastName.StartsWith("S"));
            Console.WriteLine("\nEmployees with Last Name starting with S:");
            foreach (var emp in employeesWithLastNameS)
            {
                Console.WriteLine(emp);
            }
            Console.ReadLine();
        }
    }
   
}

