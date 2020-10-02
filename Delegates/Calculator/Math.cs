using System;

namespace Delegates.Calculator
{
    public static class Math 
    {
        public delegate int Calculator(int firstNumber, int secondNumber);

        public static int Sum(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }

        public static int Sub(int firstNumber, int secondNumber)
        {
            return firstNumber - secondNumber;
        }

        public static int Mul(int firstNumber, int secondNumber)
        {
            return firstNumber * secondNumber;
        }
    }
}
