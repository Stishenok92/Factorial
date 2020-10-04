using System;
using System.ComponentModel.DataAnnotations;

namespace FactorialLibrary
{
    public class Factorial
    {
        public static int MIN_NATURAL_NUMBER = 1;

        public static bool ValidationNaturalNumber(int number)
        {
            return number >= MIN_NATURAL_NUMBER;
        }

        public static long CalculateFactorial(int number)
        {
            if (!ValidationNaturalNumber(number))
            {
                throw new ValidationException();
            }

            long factorial = 1;

            for (int i = 1; i <= number; i++)
            {
                factorial *= i;
            }

            return factorial;
        }
    }
}