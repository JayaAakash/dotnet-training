using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Customer
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Phone { get; set; }
        public string City { get; set; }

        public Customer()
        {
            Console.WriteLine("Default constructor called.");
        }

        public Customer(int customerId, string name, int age, string phone, string city)
        {
            CustomerId = customerId;
            Name = name;
            Age = age;
            Phone = phone;
            City = city;
            Console.WriteLine("Parameterized constructor called.");
        }

        ~Customer()
        {
            Console.WriteLine("Destructor called.");
        }

        public static void DisplayCustomer(Customer customer)
        {
            Console.WriteLine("Displaying customer information:");
            Console.WriteLine($"Customer ID: {customer.CustomerId}");
            Console.WriteLine($"Name: {customer.Name}");
            Console.WriteLine($"Age: {customer.Age}");
            Console.WriteLine($"Phone: {customer.Phone}");
            Console.WriteLine($"City: {customer.City}");
        }
    }

    class customer
    {
        static void Main()
        {
            Customer customer1 = new Customer();

            Customer customer2 = new Customer(1, "Banu rekha", 30, "1234567890", "chennai");

            Customer.DisplayCustomer(customer1);
            Customer.DisplayCustomer(customer2);
            Console.ReadLine();

        }
    }
}