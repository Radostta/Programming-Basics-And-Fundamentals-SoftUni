using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int width = 5 * n;
            int height = 3 * n + 2;

            int sideDotsCount = n;
            int middle = width - 2 - sideDotsCount * 2;

            for (int row = 0; row < n; row++)
            {
                if (row == 0) Console.WriteLine("{0}*{1}*{0}", new string('.', sideDotsCount), new string('*', middle));
                else Console.WriteLine("{0}*{1}*{0}", new string('.', sideDotsCount), new string('.', middle));
                sideDotsCount--;
                middle += 2;
            }

            Console.WriteLine(new string('*', width));

            sideDotsCount++;
            middle -= 2;

            for (int row = 0; row <= n * 2; row++)
            {
                if (row == n * 2) Console.WriteLine("{0}*{1}*{0}", new string('.', sideDotsCount), new string('*', middle));                
                else Console.WriteLine("{0}*{1}*{0}", new string('.', sideDotsCount), new string('.', middle));
                sideDotsCount++;
                middle -= 2;
            }
        }
    }
}
