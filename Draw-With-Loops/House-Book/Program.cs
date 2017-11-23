using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House_Book
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int stars = 1;
            if (n % 2 == 0)
            {
                stars = 2;
            }
            int dashes = (n - stars) / 2;

            for (int row = 0; row < (n + 1) / 2; row++)
            {
                Console.WriteLine("{0}{1}{0}", new string('-', dashes), new string('*', stars));
                stars = stars + 2;
                dashes--;
            }

            for (int row = 0; row < n / 2; row++)
            {
                Console.WriteLine("|{0}|", new string('*', n - 2));
            }
        }
    }
}

