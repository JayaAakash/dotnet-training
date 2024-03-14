using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Assessment3
{
    class file
    {
        static void Main(string[] args)
        {
            try
            {
                string filePath = "file.txt";
                string textToAppend = "Hello good morning !!";

                if (!File.Exists(filePath))
                {
                    using (StreamWriter sw = File.CreateText(filePath))
                    {
                        sw.WriteLine(textToAppend);
                    }

                    Console.WriteLine("The new file was created and text has been appended successfully in the new file.");
                }
                else
                {
                    using (StreamWriter sw = File.AppendText(filePath))
                    {
                        sw.WriteLine(textToAppend);
                    }

                    Console.WriteLine("Text appended to the existing file.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            Console.ReadLine();
        }
    }
}
