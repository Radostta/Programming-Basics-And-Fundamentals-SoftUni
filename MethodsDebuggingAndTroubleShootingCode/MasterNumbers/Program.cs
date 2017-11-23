using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                bool isPalindrome = CheckPalindrome(i);
                bool isDivisibleBySeven = CheckDivisibleBySeven(i);
                bool hasEvenDigit = CheckEvenDigit(i);

                if (isPalindrome && isDivisibleBySeven && hasEvenDigit)
                {
                    Console.WriteLine(i);
                }
            }

        }

        private static bool CheckEvenDigit(int i)
        {
            while (i > 0)
            {
                int digit = i % 10;
                if (digit % 2 == 0)
                {
                    return true;
                }
                i /= 10;
            }
            return false;
        }

        private static bool CheckDivisibleBySeven(int i)
        {
            int sum = 0;
            while (i > 0)
            {
                sum += i % 10;
                i /= 10;
            }
            if (sum % 7 == 0)
            {
                return true;
            }
            return false;
        }

        private static bool CheckPalindrome(int i)
        {
            var number = i;
            var reversedNumber = 0;

            while (i > 0)
            {
                int lastDigit = i % 10;
                reversedNumber = reversedNumber * 10 + lastDigit;

                i /= 10;
            }
            if (number == reversedNumber)
            {
                return true;
            }
            return false;
            
            //This is too slow and takes memory:

            //string number = i.ToString();
            //string reverse = new string(number.Reverse().ToArray());

            //if (number == reverse)
            //{
            //    return true;
            //}
            //return false;
        }
    }
}
