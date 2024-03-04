using System;


namespace Assessment
{

    class exchange_string
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string:");
            string input = Console.ReadLine();

            string result = ExchangeFirstAndLastCharacters(input);

            Console.WriteLine("Result: " + result);
            Console.ReadLine();
        }

        static string ExchangeFirstAndLastCharacters(string input)
        {
            if (string.IsNullOrEmpty(input) || input.Length == 1)
            {
                return input;
            }
            else
            {
                char firstChar = input[0];
                char lastChar = input[input.Length - 1];


                char[] charArray = input.ToCharArray();
                charArray[0] = lastChar;
                charArray[input.Length - 1] = firstChar;

                return new string(charArray);
            }
        }
    }
}