using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace LineComparision
{
    public class CompareToMethods
    {
        public void CalculatingLength()
        {
            Console.WriteLine("Calculating the Length Of The First Line");
            int x1, y1, x2, y2;

            Console.WriteLine("Entering the value of x1 :");
            x1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Entering the value of y1 :");
            y1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Entering the value of x2 :");
            x2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Entering the value of y2 :");
            y2 = Convert.ToInt32(Console.ReadLine());

            var line1 = Math.Sqrt((Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)));

            Console.WriteLine("line1 :" + line1);

            Console.WriteLine("Calculating the Length Of The Second Line");
            int x3, y3, x4, y4;

            Console.WriteLine("Entering the vaule of x3 :");
            x3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Entering the value of y3 :");
            y3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Entering the value of x4 :");
            x4 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Entering the value of y4 :");
            y4 = Convert.ToInt32(Console.ReadLine());

            var line2 = Math.Sqrt((Math.Pow(x4 - x3, 2) + Math.Pow(y4 - y3, 2)));

            Console.WriteLine("line2 :" + line2);

            Console.WriteLine("----------ComparionTo Method----------");

            Console.WriteLine("Line 1 = " + line1);
            Console.WriteLine("Line 2 = " + line2);
            Console.WriteLine("Return value (comparison) = " + line1.CompareTo(line2));
        }


    }
}
