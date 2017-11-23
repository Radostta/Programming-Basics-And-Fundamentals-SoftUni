using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExactSumOfRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            decimal sum = 0m;

            for (int currentNumber = 0; currentNumber < n; currentNumber++)
            {
                decimal number = decimal.Parse(Console.ReadLine());
                sum += number;
            }

            Console.WriteLine(sum);
        }

    }
}
