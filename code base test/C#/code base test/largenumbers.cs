using System;

namespace Assessment
{ 
class largenumbers
{
    static void Main(string[] args)
    {
        CheckLargestNumber(1, 2, 3);
        CheckLargestNumber(1, 3, 2);
        CheckLargestNumber(1, 1, 1);
        CheckLargestNumber(1, 2, 2);
    }

    static void CheckLargestNumber(int num1, int num2, int num3)
    {
        int max = Math.Max(num1, Math.Max(num2, num3));
        Console.WriteLine(max);
            Console.ReadLine();
    }
}
}