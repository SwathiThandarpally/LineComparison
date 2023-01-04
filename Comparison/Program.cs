using LineComparison;
using LineComparison.LineComparison.Comparison;

namespace LineComparision
{
    class Program
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Welcome to Line Comparison Computation Program");
            Console.WriteLine("----------------------------------");
            //Usecase-1
            double firstline, secondline;
            CalculatingLength uC_1Calculate = new CalculatingLength(3, 4, 5, 6);
            uC_1Calculate.Calculate();
            Console.WriteLine("----------------------------------");

            //Usecase-2
            CheckEquality line = new CheckEquality(5, 6, 7, 8);
            line.Checking();
            CheckEquality line1 = new CheckEquality(1, 2, 3, 4);
            line1.Checking();
            if (line == line1)
            {
                Console.WriteLine("Two lines are Equal");
            }
            else
            {
                Console.WriteLine("Two lines are Not equal");
            }
            Console.WriteLine("-----------------------------------");

        }
    }
}