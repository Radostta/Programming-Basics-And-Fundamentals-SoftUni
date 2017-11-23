using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfOddNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int oddSum = 0;

            for (int i = 1; i <= n * 2; i += 2)
            {                
                    Console.WriteLine(i);
                    oddSum += i;                
            }

            Console.WriteLine("Sum: {0}", oddSum);
        }
    }
}
