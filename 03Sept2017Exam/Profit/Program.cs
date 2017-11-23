using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Profit
{
    class Program
    {
        static void Main(string[] args)
        {
            int oneLevaCount = int.Parse(Console.ReadLine());
            int twoLevaCount = int.Parse(Console.ReadLine());
            int fiveLevaCount = int.Parse(Console.ReadLine());           
            int sum = int.Parse(Console.ReadLine());

            //Console.WriteLine("ok");

            for (int one = 0; one <= oneLevaCount; one++)
            {
                for (int two = 0; two <= twoLevaCount; two++)
                {
                    for (int five = 0; five <= fiveLevaCount; five++)
                    {
                        if (one * 1 + two * 2 + five * 5 == sum) Console.WriteLine($"{one} * 1 lv. + {two} * 2 lv. + {five} * 5 lv. = {sum} lv.");
                    }
                }
            }      

        }
    }
}
