using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assingments
{
    class strings
    {
        static void Main()
        {
            Console.Write("Enter a word: ");
            string word = Console.ReadLine();
            Console.WriteLine($"Length of the word: {word.Length}");

            Console.Write("Enter another word: ");
            string word2 = Console.ReadLine();
            string reversedWord = ReverseString(word2);
            Console.WriteLine($"Reverse of the word: {reversedWord}");

            Console.Write("Enter the first word: ");
            string firstWord = Console.ReadLine();
            Console.Write("Enter the second word: ");
            string secondWord = Console.ReadLine();

            if (string.Equals(firstWord, secondWord, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("The two words are the same.");
            }
            else
            {
                Console.WriteLine("The two words are different.");
            }
            Console.ReadLine();
        }

        static string ReverseString(string str)
        {
            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
