using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            //
            for (int number = 1111; number <= 9999; number++)
            {
                int first = number % 10;
                int newNumber = number / 10;
                int second = newNumber % 10;
                newNumber = newNumber / 10;
                int third = newNumber % 10;
                newNumber = newNumber / 10;
                int forth = newNumber % 10;               

                if (first == 0 || second == 0 || third == 0 || forth == 0) continue;
                if (n % first == 0 && n % second == 0 && n % third == 0 && n % forth == 0)
                {
                    Console.Write(number + " ");
                }
            }
            Console.WriteLine();

            //Solution 2:
            //for (int number = 1111; number <= 9999; number++)
            //{
            //    int a = number % 10 / 1;
            //    int b = number % 100 / 10;
            //    int c = number % 1000 / 100;
            //    int d = number % 10000 / 1000;

            //    if (a == 0 || b == 0 || c == 0 || d == 0)
            //    { continue; }
            //    if (n % a == 0 && n % b == 0 && n % c == 0 && n % d == 0)
            //    {
            //        Console.Write(number + " ");
            //    }
            //}
            //Console.WriteLine();


            //Solution 1:
            //for (int i1 = 1; i1 <= 9; i1++)
            //{
            //    for (int i2 = 1; i2 <= 9; i2++)
            //    {
            //        for (int i3 = 1; i3 <= 9; i3++)
            //        {
            //            for (int i4 = 1; i4 <= 9; i4++)
            //            {
            //                if (n % i1 == 0 && n % i2 == 0 && n % i3 == 0 && n % i4 == 0)
            //                {
            //                    Console.Write($"{i1}{i2}{i3}{i4} ");
            //                }
            //            }
            //        }
            //    }
            //}



        }
    }
}
