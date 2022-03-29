using System;

namespace Lesson23
{
    internal class Program
    {
        public delegate void CalculatorFunction(double x, double y);

        static void Main(string[] args)
        {
            CalculatorFunction cs = calc;
            cs.Invoke(5.5, 6.60);
        }

        static void calc(double x, double y)
        {

            Console.WriteLine(x + y);
        }
    }
}