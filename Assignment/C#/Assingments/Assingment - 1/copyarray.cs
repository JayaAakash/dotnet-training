using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assingments
{
    class copyarray
    {
        static void Main()
        {
            int[] originalArray = { 1, 2, 3, 4, 5 };

            int[] copiedArray = new int[originalArray.Length];

            for (int i = 0; i < originalArray.Length; i++)
            {
                copiedArray[i] = originalArray[i];
            }

            Console.WriteLine("Copied Array:");
            foreach (int num in copiedArray)
            {
                Console.Write(num + " ");
            }
            Console.ReadLine();
        }
    }
}