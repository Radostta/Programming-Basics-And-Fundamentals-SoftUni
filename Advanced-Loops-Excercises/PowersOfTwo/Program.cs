using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowersOfTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            //takes too much TIME

            //for (int i = 1; i <= Math.Pow(2, n); i*=2) // 1 << 2 == Math.Pow(2, n) => Power n of 2
            //{
            //    Console.WriteLine(i);
            //}

            //too complicated

            //for (int i = 0, num = 1; i <= n; i++, num *= 2)
            //{
            //    Console.WriteLine(num);
            //}

            //the right solution

            int num = 1;
            for (int i = 0; i <= n; i++)
            {
                Console.WriteLine(num);
                num *= 2;
            }
        }
    }
}
