using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int maxSum = int.Parse(Console.ReadLine());
            int combinations = 0;
            int totalSum = 0;
            bool sumIsBigger = false;

            for (int d1 = n; d1 >= 1; d1--)
            {
                for (int d2 = 1; d2 <= m; d2++)
                {
                    combinations++;
                    int currentSum = 3 * (d1 * d2);
                    totalSum += currentSum;
                    if (totalSum >= maxSum)
                    {
                        sumIsBigger = true;
                        break;
                    }
                }

                if (totalSum >= maxSum)
                {
                    sumIsBigger = true;
                    break;
                }
            }

            Console.WriteLine($"{combinations} combinations");

            if (sumIsBigger)
            {
                Console.WriteLine($"Sum: {totalSum} >= {maxSum}");
            }
            else
            {
                Console.WriteLine($"Sum: {totalSum}");
            }
        }
    }
}
