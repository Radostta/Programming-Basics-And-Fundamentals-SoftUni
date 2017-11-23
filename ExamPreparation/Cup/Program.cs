using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cup
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); //even number
            int width = 5 * n;

            int sideDots = n;
            int middle = width - sideDots * 2 - 2;

            for (int row = 1; row <= n + 2; row++)
            {
                if (row <= n / 2)
                {
                    Console.WriteLine("{0}#{1}#{0}", new string('.', sideDots), new string('#', middle));
                }    
                else if (row == n + 2)
                {
                    Console.WriteLine("{0}{1}{0}", new string('.', n * 2), new string('#', n));
                }
                else
                {
                    Console.WriteLine("{0}#{1}#{0}", new string('.', sideDots), new string('.', middle));
                }

                sideDots++;
                middle -= 2;
            }

            //bottom part

            middle = n + 4;
            sideDots = (width - middle) / 2;

            for (int row = 1; row <= n + 2; row++)
            {
                if (row == (n + 2) / 2)
                {
                    int newSideDots = (width - 10) / 2;
                    Console.WriteLine("{0}D^A^N^C^E^{0}", new string('.', newSideDots));
                }                
                else
                {
                    Console.WriteLine("{0}{1}{0}", new string('.', sideDots), new string('#', middle));
                }               
            }
        }
    }
}
