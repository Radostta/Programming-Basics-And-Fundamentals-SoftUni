using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int width = (4 * n) + 1;
            int height = (2 * n) + 1;

            Console.WriteLine($"{new string('#', width)}"); // first line

            int sideDots = 1;
            int middle = 1;
            int sideHashtags = (width - sideDots * 2 - middle) / 2;

            for (int row = 1; row <= n; row++)
            {
                if (row == n / 2 + 1)
                {
                    int newMiddle = (middle - 3) / 2;
                    Console.WriteLine("{0}{1}{2}(@){2}{1}{0}", new string('.', sideDots), new string('#', sideHashtags), new string(' ', newMiddle));
                }
                else
                {
                    Console.WriteLine("{0}{1}{2}{1}{0}", new string('.', sideDots), new string('#', sideHashtags), new string(' ', middle));
                }
                sideDots++;
                middle += 2;
                sideHashtags -= 2;
            }

            sideDots = n + 1;
            middle = width - sideDots * 2;
            for (int row = 0; row < n; row++)
            {
                Console.WriteLine("{0}{1}{0}", new string('.', sideDots), new string('#', middle));
                sideDots++;
                middle -= 2;
            }
        }
    }
}
