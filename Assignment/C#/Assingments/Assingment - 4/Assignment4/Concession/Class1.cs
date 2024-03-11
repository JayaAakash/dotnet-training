using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    namespace ConcessionLibrary
    {
        public class TicketConcession
        {
            private const int TotalFare = 500;

            public string Name { get; set; }
            public int Age { get; set; }

            public void CalculateConcession()
            {
                if (Age <= 5)
                {
                    Console.WriteLine($"Little Champs - Free Ticket for {Name}, Age: {Age}");
                }
                else if (Age > 60)
                {
                    double concessionAmount = TotalFare * 0.30;
                    double discountedFare = TotalFare - concessionAmount;
                    Console.WriteLine($"Senior Citizen - Fare after 30% concession: {discountedFare} for {Name}, Age: {Age}");
                }
                else
                {
                    Console.WriteLine($"Ticket Booked - Fare: {TotalFare} for {Name}, Age: {Age}");
                }
            }
        }
    }

