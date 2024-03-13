using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    public class Box
    {
        public double Length { get; set; }
        public double Breadth { get; set; }

        public Box(double length, double breadth)
        {
            Length = length;
            Breadth = breadth;
        }

        public static Box AddBoxes(Box box1, Box box2)
        {
            double newLength = box1.Length + box2.Length;
            double newBreadth = box1.Breadth + box2.Breadth;

            return new Box(newLength, newBreadth);
        }

        public void DisplayBox()
        {
            Console.WriteLine($"Box Length: {Length}, Breadth: {Breadth}");
        }
    }

    public class boxes
    {
        static void Main()
        {
            Box box1 = new Box(2, 1);
            Box box2 = new Box(3, 6);

            Box box3 = Box.AddBoxes(box1, box2);

            Console.WriteLine("Details of the new Box:");
            box3.DisplayBox();
            Console.ReadLine();
        }
    }

}