using System;


namespace code_base_test
{
    class remove
    {
        static void Main(string[] args)
        {
            RemoveCharacterAtPosition("Python", 1);
            RemoveCharacterAtPosition("Python", 0);
            RemoveCharacterAtPosition("Python", 4);
        }

        static void RemoveCharacterAtPosition(string input, int position)
        {
            if (position < 0 || position >= input.Length)
            {
                Console.WriteLine("Invalid position");
            }
            else
            {
                string result = input.Remove(position, 1);
                Console.WriteLine(result);
                Console.ReadLine();
            }
        }
    }
}