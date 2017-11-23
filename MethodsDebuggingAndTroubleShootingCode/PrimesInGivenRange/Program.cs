using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimesInGivenRange
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            CheckRangeForPrimes(num1, num2);             
        }

        private static void CheckRangeForPrimes(int num1, int num2)
        {
            List<int> numbers = new List<int>();

            if (num1 > num2)
            {
                Console.WriteLine("(empty list)");
                return;
            }
            if (num1 <= 1 || num2 < 0)
            {
                num1 = 2;
            }

            for (int number = num1; number <= num2; number++)
            {
                bool isPrime = IsPrime(number);

                if (isPrime)
                {
                    numbers.Add(number);
                }
            }
            Print(numbers);
        }

        static void Print(List<int> numbers)
        {
            Console.WriteLine(string.Join(", ", numbers));
        }

        static bool IsPrime(int number)
        {
            bool isPrime = true;

            if (number < 2)
            {
                isPrime = false;
            }

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            return isPrime;
        }

    }
}
