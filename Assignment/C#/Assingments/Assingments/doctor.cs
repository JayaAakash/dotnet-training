using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assingments
{
    using System;

    class Doctor
    {
        private int RegnNo;
        private string Name;
        private double FeesCharged;

        public void SetDoctorDetails(int regnNo, string name, double feesCharged)
        {
            RegnNo = regnNo;
            Name = name;
            FeesCharged = feesCharged;
        }

        public void DisplayDoctorDetails()
        {
            Console.WriteLine($"Registration Number: {RegnNo}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Fees Charged: {FeesCharged}");
        }
    }

    class doctor
    {
        static void Main(string[] args)
        {
            Doctor doctor = new Doctor();

            doctor.SetDoctorDetails(0001, "Dr. Banu rekha", 1000);

            Console.WriteLine("Doctor Details:");
            doctor.DisplayDoctorDetails();
            Console.ReadLine();
        }
    }
}