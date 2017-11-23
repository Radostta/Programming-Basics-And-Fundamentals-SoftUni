using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hourglass
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); //odd number
            int width = 2 * n + 1;
            int height = width;

            Console.WriteLine(new string('*', width)); //first line

            int sideDotsCount = 1;
            int middle = width - 2 - sideDotsCount * 2;

            for (int row = 0; row < n - 1; row++)
            {
                if (row == 0) Console.WriteLine("{0}*{1}*{0}", new string('.', sideDotsCount), new string(' ', middle));
                else Console.WriteLine("{0}*{1}*{0}", new string('.', sideDotsCount), new string('@', middle));

                sideDotsCount++;
                middle -= 2;
            }

            Console.WriteLine("{0}*{0}", new string('.', n)); // middle lines
            Console.WriteLine("{0}*@*{0}", new string('.', n - 1)); // middle lines


            sideDotsCount = n - 2;
            int sideMiddle = 1;

            for (int row = 0; row < n - 2; row++)
            {
                if (row == n - 3) Console.WriteLine("{0}*{1}@{1}*{0}", new string('.', sideDotsCount), new string('@', sideMiddle));

                else Console.WriteLine("{0}*{1}@{1}*{0}", new string('.', sideDotsCount), new string(' ', sideMiddle));

                sideDotsCount--;
                sideMiddle += 1;
            }

            Console.WriteLine(new string('*', width)); //last line


        }
    }
}
