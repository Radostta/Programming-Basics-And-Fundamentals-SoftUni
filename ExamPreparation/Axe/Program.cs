using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axe
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int width = 5 * n;

            int leftDashes = 3 * n;
            int midDashes = 0;
            int rightDashes = width - leftDashes - midDashes - 2;

            for (int rows = 0; rows < n; rows++)
            {
                Console.WriteLine("{0}*{1}*{2}", new string('-', leftDashes), new string('-', midDashes), new string('-', rightDashes));
                midDashes++;
                rightDashes--;
            }

            midDashes--;
            rightDashes++;

            for (int rows = 0; rows < n / 2; rows++)
            {
                Console.WriteLine("{0}*{1}*{2}", new string('*', leftDashes), new string('-', midDashes), new string('-', rightDashes));
            }

            for (int rows = 1; rows <= n / 2; rows++)
            {
                if (rows == n / 2) Console.WriteLine("{0}*{1}*{2}", new string('-', leftDashes), new string('*', midDashes), new string('-', rightDashes));
                else Console.WriteLine("{0}*{1}*{2}", new string('-', leftDashes), new string('-', midDashes), new string('-', rightDashes));
                leftDashes--;
                rightDashes--;
                midDashes += 2;
                    
            }
        }
    }
}
