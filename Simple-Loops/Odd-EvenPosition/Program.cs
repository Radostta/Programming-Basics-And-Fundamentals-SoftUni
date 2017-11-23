using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odd_EvenPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var oddSum = 0.0;
            var oddMin = double.MaxValue;
            var oddMax = double.MinValue;
            var evenSum = 0.0;
            var evenMin = double.MaxValue;
            var evenMax = double.MinValue;

            for (int i = 1; i <= n; i++)
            {
                var num = double.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    evenSum += num;
                    if (num < evenMin)
                    {
                        evenMin = num;
                    }
                    if (num > evenMax)
                    {
                        evenMax = num;
                    }
                }
                else
                {
                    oddSum += num;
                    if (num < oddMin)
                    {
                        oddMin = num;
                    }
                    if (num > oddMax)
                    {
                        oddMax = num;
                    }
                }
            }

            Console.WriteLine($"OddSum={oddSum}");
            if (oddMin == double.MaxValue)
            {
                Console.WriteLine("OddMin=No");
            }
            else
            {
                Console.WriteLine($"OddMin={oddMin}");
            }
            if (oddMax == double.MinValue)
            {
                Console.WriteLine("OddMax=No");
            }
            else
            {
                Console.WriteLine($"OddMax={oddMax}");
            }
            Console.WriteLine($"EvenSum={evenSum}");
            if (evenMin == double.MaxValue)
            {
                Console.WriteLine("EvenMin=No");
            }
            else
            {
                Console.WriteLine($"EvenMin={evenMin}");
            }
            if (evenMax == double.MinValue)
            {
                Console.WriteLine("EvenMax=No");
            }
            else
            {
                Console.WriteLine($"EvenMax={evenMax}");
            }

        }
    }
}
