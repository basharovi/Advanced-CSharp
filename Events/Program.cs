using System;
using Delegates.Math;

namespace Events
{
    class Program
    {
        static event SimpleCalculator.Calculate AfterCalculation;

        static void Main(string[] args)
        {

            AfterCalculation += Operator.Sum;
            AfterCalculation += Operator.Sub;
            AfterCalculation += Operator.Mul;

            if (AfterCalculation == null) 
                return;

            var result = AfterCalculation(50, 25);

            Console.WriteLine(result);
        }
    }
}
