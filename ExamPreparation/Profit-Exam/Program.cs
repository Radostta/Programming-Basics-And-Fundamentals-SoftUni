using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Profit_Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int oneCount = int.Parse(Console.ReadLine());
            int twoCount = int.Parse(Console.ReadLine());
            int fiveCount = int.Parse(Console.ReadLine());
            int sum = int.Parse(Console.ReadLine());

            for (int ones = 0; ones <= oneCount; ones++)
            {
                for (int twos = 0; twos <= twoCount; twos++)
                {
                    for (int fives = 0; fives <= fiveCount; fives++)
                    {
                        if (ones + twos * 2 + fives * 5 == sum)
                        {
                            Console.WriteLine($"{ones} * 1 lv. + {twos} * 2 lv. + {fives} * 5 lv. = {sum} lv.");
                        }
                    }
                }
            }

        }
    }
}
