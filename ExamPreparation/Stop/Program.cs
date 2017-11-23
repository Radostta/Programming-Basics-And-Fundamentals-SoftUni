using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stop
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int middle = 2 * n - 1;
            int sideDotsCount = n;

            Console.WriteLine("{0}{1}{0}", new string('.', sideDotsCount + 1), new string('_', middle + 2)); // first line

            for (int rows = 1; rows <= n; rows++)
            {
                Console.WriteLine("{0}//{1}\\\\{0}", new string('.', sideDotsCount), new string('_', middle));
                sideDotsCount--;
                middle += 2;
            }

            int sideMiddle = middle / 2;
            Console.WriteLine("//{0}STOP!{0}\\\\", new string('_', sideMiddle - 2)); // stop line

            for (int rows = 1; rows <= n; rows++)
            {
                Console.WriteLine("{0}\\\\{1}//{0}", new string('.', sideDotsCount), new string('_', middle));
                sideDotsCount++;
                middle -= 2;

            }
        }
    }
}
