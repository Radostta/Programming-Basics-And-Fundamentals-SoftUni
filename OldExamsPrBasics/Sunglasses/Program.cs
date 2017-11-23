using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sunglasses
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); //always an odd number

            int sideWidth = n * 2;
            int bridge = n;

            Console.WriteLine("{0}{1}{0}", new string('*', sideWidth), new string(' ', bridge));

            for (int row = 1; row <= n - 2; row++)
            {
                if (row == n / 2)
                {
                    Console.WriteLine("*{0}*{1}*{0}*", new string('/', sideWidth - 2), new string('|', bridge));
                }
                else
                {
                    Console.WriteLine("*{0}*{1}*{0}*", new string('/', sideWidth - 2), new string(' ', bridge));
                }                
            }

            Console.WriteLine("{0}{1}{0}", new string('*', sideWidth), new string(' ', bridge));

        }
    }
}
