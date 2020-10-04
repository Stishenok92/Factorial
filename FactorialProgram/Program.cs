using System;
using System.ComponentModel.DataAnnotations;
using static FactorialLibrary.Factorial;

namespace FactorialProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task \"Factorial\"\n");

            try
            {
                Console.Write("Enter natural number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Factorial: " + CalculateFactorial(number));
            }
            catch (ValidationException)
            {
                Console.WriteLine("\nError: ValidationException");
            }
            catch (FormatException)
            {
                Console.WriteLine("\nError: FormatException");
            }
        }
    }
}