using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int fibonacciNumber = FindFibonacci(n);
            Console.WriteLine(fibonacciNumber);
        }

        static int FindFibonacci(int n)
        {
            int first = 1;
            int second = 1;
            if (n < 2)
            {
                return first;
            }

            int next = first + second;

            for (int i = 2; i < n; i++)
            {
                first = second;
                second = next;
                next = second + first;
            }

            return next;
        }
    }
}
