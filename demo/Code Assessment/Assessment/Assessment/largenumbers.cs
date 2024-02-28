using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment
{
    class largenumbers
    {

        class NumberChecker
        {
            public static void CheckLargestNumber(int num1, int num2, int num3)
            {
                int max = Math.Max(num1, Math.Max(num2, num3));
                Console.WriteLine(max);
            }
        }

    }
}
