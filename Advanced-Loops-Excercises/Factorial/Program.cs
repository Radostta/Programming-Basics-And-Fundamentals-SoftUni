using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            //SOLUTION 3
            int result = 1;
            for (int i = 2; i <= n; i++)
            {
                result *= i;
            }

            Console.WriteLine(result);
            
            //SOLUTION 2
            //int fact = 1;
            //int counter = 1;
            //do
            //{
            //    fact *= counter;
            //    counter++;
            //} while (counter <= n);
            //Console.WriteLine(fact);

            
            //SOLUTION 1
            //int fact = 1;

            //do
            //{
            //    fact = fact * n;
            //    n--;
            //} while (n > 1);
            //Console.WriteLine(fact);

        }
    }
}
