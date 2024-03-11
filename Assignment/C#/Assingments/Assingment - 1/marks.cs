using System;


namespace Asssignments
{
    class Marks
    {
        static void Main()
        {
            int[] marks = new int[10];

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Enter mark {i + 1}: ");
                marks[i] = Convert.ToInt32(Console.ReadLine());
            }

            int total = 0;
            foreach (int mark in marks)
            {
                total += mark;
            }
            double average = (double)total / marks.Length;

            int minMark = marks[0];
            int maxMark = marks[0];
            foreach (int mark in marks)
            {
                if (mark < minMark)
                {
                    minMark = mark;
                }
                if (mark > maxMark)
                {
                    maxMark = mark;
                }
            }

            Array.Sort(marks);

            Console.WriteLine($"Total: {total}");
            Console.WriteLine($"Average: {average:F2}");
            Console.WriteLine($"Minimum marks: {minMark}");
            Console.WriteLine($"Maximum marks: {maxMark}");

            Console.WriteLine("Marks in ascending order:");
            foreach (int mark in marks)
            {
                Console.Write($"{mark} ");
            }
            Console.WriteLine();

            Console.WriteLine("Marks in descending order:");
            Array.Reverse(marks);
            foreach (int mark in marks)
            {
                Console.Write($"{mark} ");
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}