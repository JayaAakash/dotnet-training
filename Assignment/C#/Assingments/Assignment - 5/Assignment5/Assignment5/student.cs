using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    public interface IStudent
    {
        int StudentId { get; set; }
        string Name { get; set; }

        void ShowDetails();
    }

    public class Dayscholar : IStudent
    {
        public int StudentId { get; set; }
        public string Name { get; set; }

        public void ShowDetails()
        {
            Console.WriteLine($"Dayscholar Details: Student ID - {StudentId}, Name - {Name}");
        }
    }

    public class Resident : IStudent
    {
        public int StudentId { get; set; }
        public string Name { get; set; }

        public void ShowDetails()
        {
            Console.WriteLine($"Resident Details: Student ID - {StudentId}, Name - {Name}");
        }
    }

    public class student
    {
        public static void Main()
        {
            Dayscholar dayscholar = new Dayscholar { StudentId = 01, Name = "Banu Rekha" };
            dayscholar.ShowDetails();

            Resident resident = new Resident { StudentId = 02, Name = "Jaya Aakash" };
            resident.ShowDetails();
            Console.ReadLine();
        }
    }
}