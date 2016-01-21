using System;

namespace Exceptions_Homework
{
    public class CheckerIsPrime
    {
        public static bool CheckPrime(int number)
        {
            bool isPrime = false;
            for (int divisor = 2; divisor <= Math.Sqrt(number); divisor++)
            {
                if (number % divisor != 0)
                {
                    isPrime = true;
                }
            }

            return isPrime;
        }
    }
}
