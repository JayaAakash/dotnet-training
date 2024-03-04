using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace my_practice_cases
{
        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Welcome to my first demo application !!....");
                Console.WriteLine("enter your name:");
                string name = Console.ReadLine();
                Console.WriteLine("where you reside:");
                string place = Console.ReadLine();
                Cricket cricket = new Cricket();
                cricket.team();

                Console.Read();

            }
        }
        class Cricket
        {
            public void team()
            {

                Console.WriteLine("enter your fav player name to see score virat/rohit/d/honi/pandya/rahul");
                string inputString = Console.ReadLine();
                if (inputString == "virat")
                    Console.WriteLine("virat scored 100");
                else if (inputString == "dhoni")
                    Console.WriteLine("dhoni scored 103");
                else if (inputString == "rohit")
                    Console.WriteLine("rohit scored 109");
                else if (inputString == "pandya")
                    Console.WriteLine("pandya scored 77");
                else if (inputString == "rahul")
                    Console.WriteLine("rahul scored 88");
                else
                    Console.WriteLine("invalid player");
            }

        }
    }
