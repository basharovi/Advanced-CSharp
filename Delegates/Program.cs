using System;
using Delegates.Math;

namespace Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            var calculate = new SimpleCalculator.Calculate(Operator.Mul);

            var result = calculate(10, 15);

            Console.WriteLine("Result = {0}", result);
        }
    }
}
