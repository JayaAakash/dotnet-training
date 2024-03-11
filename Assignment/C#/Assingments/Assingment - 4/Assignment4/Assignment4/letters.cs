using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class letters
    {
        static void Main()
        {
            List<string> words = new List<string> { "amsterdam", "bloom", };

            var result = words.Where(word => word.StartsWith("a", StringComparison.OrdinalIgnoreCase) &&
                                              word.EndsWith("m", StringComparison.OrdinalIgnoreCase));


            Console.WriteLine("Words starting with 'a' and ending with 'm':");

            foreach (var word in result)
            {
                Console.WriteLine(word);
            }
            Console.ReadLine();
        }
    }
}
