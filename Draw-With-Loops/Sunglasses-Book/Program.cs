using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sunglasses_Book
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int row = 0; row < n; row++)
            {
                char symbolInside = '/';
                if (row == 0 || row == n - 1)
                {
                    symbolInside = '*';
                }                
               
                Console.Write("*{0}*", new string(symbolInside, 2 * n - 2));
                if (row == (n - 1) / 2)
                {
                    Console.Write(new string('|', n));               
                }
                else
                {
                    Console.Write(new string(' ', n));
                }
                Console.WriteLine("*{0}*", new string(symbolInside, 2 * n - 2));
            }
        }
    }
}
