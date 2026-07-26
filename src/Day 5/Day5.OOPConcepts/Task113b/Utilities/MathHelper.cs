using System;

namespace Day5.OOPConcepts.Task113b.Utilities
{
	public static class MathHelper
	{
        public static long Factorial(int n)
        {
            if (n < 0)
                throw new ArgumentOutOfRangeException(nameof(n), "Value must be non-negative.");

            long result = 1;
            for (int i = 2; i <= n; i++)
            {
                result *= i;
            }

            return result;
        }
        public static bool IsPrime(int number)
        {
            if (number < 2)
                return false;

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                    return false;
            }

            return true;
        }
        public static int GCD(int firstNumber, int secondNumber)
        {
            while (secondNumber != 0)
            {
                int remainder = firstNumber % secondNumber;

                firstNumber = secondNumber;

                secondNumber = remainder;
            }

            return firstNumber;
        }
    }
}
