using System;
using System.Numerics;

namespace Factorial
{
    class Program
    {        
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            BigInteger printFact = CalculateFactorial(number);
            Console.WriteLine(printFact);
        }

        static BigInteger CalculateFactorial(int number)
        {
            BigInteger factorial = 1;
            for (int i = 1; i <= number; i++)
            {
                factorial = factorial * i;
            }
            return factorial;
        }
    }
}