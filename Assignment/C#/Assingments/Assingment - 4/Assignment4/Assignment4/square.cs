using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class square
    {

        static void Main()
        {
            List<int> numbers = new List<int> { 7, 2, 30 };

            var result = numbers.Select(x => new { Number = x, Square = x * x })
                                .Where(x => x.Square > 20)
                                .Select(x => x.Square);

            Console.WriteLine("Numbers and their squares greater than 20:");
            foreach (var square in result)
            {
                Console.WriteLine(square);
            }
            Console.ReadLine();
        }

    }
}
