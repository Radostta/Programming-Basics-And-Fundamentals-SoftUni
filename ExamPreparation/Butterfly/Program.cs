using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Butterfly
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int width = 2 * n - 1;
            int height = 2 * (n - 2) + 1;

            int sideSymbols = n - 2;

            for (int row = 1; row <= n - 2; row++)
            {
                if (row % 2 == 0) Console.WriteLine("{0}\\ /{0}", new string('-', sideSymbols));
                else Console.WriteLine("{0}\\ /{0}", new string('*', sideSymbols));
            }

            Console.WriteLine("{0}@{0}", new string(' ', n - 1));

            for (int row = 1; row <= n - 2; row++)
            {
                if (row % 2 == 0) Console.WriteLine("{0}/ \\{0}", new string('-', sideSymbols));
                else Console.WriteLine("{0}/ \\{0}", new string('*', sideSymbols));
            }
        }

    }
}
