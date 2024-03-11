using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class strcount
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string:");
            string inputString = Console.ReadLine();

            Console.WriteLine("Enter the letter to count:");
            char letterToCount = Console.ReadKey().KeyChar;
            Console.WriteLine(); // Move to the next line after reading the letter

            int count = CountOccurrences(inputString, letterToCount);
            Console.WriteLine($"Number of occurrences of '{letterToCount}' in string: {count}");
            Console.ReadLine();
        }

        static int CountOccurrences(string input, char letter)
        {
            int occurrenceCount = 0;
            foreach (char a in input)
            {
                if (a == letter)
                {
                    occurrenceCount++;
                }
            }
            return occurrenceCount;
        }
    }
}

