using System;
using Math = Delegates.Calculator.Math;

namespace Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            var sumCalculator = new Math.Calculator(Math.Sum);
            var mulCalculator = new Math.Calculator(Math.Mul);

            var sum = sumCalculator(10, 20);
            var mul = mulCalculator(10, 20);

            Console.WriteLine(" Sum = {0} \n Mul = {1}", sum, mul);
        }
    }
}
