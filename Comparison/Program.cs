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
        }
    }
}