using System;


namespace Asssignments
{
    class array
    {
        static void Main()
        {
            
            int[] numbers = { 5, 10, 15, 20, 25 };

            double average = CalculateAverage(numbers);
            Console.WriteLine("Average value of array elements: " + average);

            int min = FindMinValue(numbers);
            int max = FindMaxValue(numbers);
            Console.WriteLine("Minimum value in the array: " + min);
            Console.WriteLine("Maximum value in the array: " + max);
            Console.ReadLine();

        }

        static double CalculateAverage(int[] array)
        {
            int sum = 0;
            foreach (int num in array)
            {
                sum += num;
            }
            return (double)sum / array.Length;
        }

        static int FindMinValue(int[] array)
        {
            int min = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
            }
            return min;
        }

        static int FindMaxValue(int[] array)
        {
            int max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            return max;
        }
    }
}