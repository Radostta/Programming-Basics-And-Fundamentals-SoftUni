using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenPowersOfTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int num = 1;

            for (int i = 0; i <= n; i+=2)
            {
                Console.WriteLine(num);
                num *= 4;
            }


            //for (int i = 0; i <= n/2; i++) // 2^n = 4^n/2 ==> 2*2 = 4*1;
            //{
            //    Console.WriteLine(num);
            //    num *= 2 * 2;
            //}
        }
    }
}
