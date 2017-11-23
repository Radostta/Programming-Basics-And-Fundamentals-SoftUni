using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecialNumbers_Book
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int number = 1111; number <= 9999; number++)
            {
                int d1 = number % 10000 / 1000;
                int d2 = number % 1000 / 100;
                int d3 = number % 100 / 10;
                int d4 = number % 10 / 1;

                if (d1 == 0 || d2 == 0 || d3 == 0 || d4 == 0) continue;
                if (n % d1 == 0 && n % d2 == 0 && n % d3 == 0 && n % d4 == 0)
                {
                    Console.Write($"{d1}{d2}{d3}{d4} ");
                }
            }
            Console.WriteLine();

            //for (int d1 = 1; d1 <= 9; d1++)
            //{
            //    for (int d2 = 1; d2 <= 9; d2++)
            //    {
            //        for (int d3 = 1; d3 <= 9; d3++)
            //        {
            //            for (int d4 = 1; d4 <= 9; d4++)
            //            {
            //                if (n % d1 == 0 && n % d2 == 0 && n % d3 == 0 && n % d4 == 0)
            //                {
            //                    Console.Write($"{d1}{d2}{d3}{d4} ");
            //                }
            //            }
            //        }
            //    }
            //}
            //Console.WriteLine();
        }
    }
}
