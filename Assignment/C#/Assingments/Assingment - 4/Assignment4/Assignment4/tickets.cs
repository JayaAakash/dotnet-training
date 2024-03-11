using System;
using ConcessionLibrary;

namespace Assignment4
{
    class Tickets
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter your age:");
            int age = Convert.ToInt32(Console.ReadLine());

            TicketConcession ticket = new TicketConcession
            {
                Name = name,
                Age = age
            };

            ticket.CalculateConcession();
            Console.ReadLine();
        }
    }
}