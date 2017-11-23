using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5DrawingWithLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int width = 3 * n;
            int height = 2 * n + 8;

            int sideDots = (width - 1) / 2;
            Console.WriteLine("{0}x{0}", new string('.', sideDots)); // first line
            Console.WriteLine("{0}/x\\{0}", new string('.', sideDots - 1)); // second line
            Console.WriteLine("{0}x|x{0}", new string('.', sideDots - 1)); // third line

            //top part
            //increasing
            int x = n;
            sideDots = (width - 1 - 2 * x) / 2;
        
            for (int i = 0; i < (n + 1) / 2; i++)
            {
                Console.WriteLine("{0}{1}|{1}{0}", new string('.', sideDots), new string('x', x));
                sideDots--;
                x++;
            }

            //decreasing

            x -= 2;
            sideDots = 1;

            for (int i = 0; i < n / 2; i++)
            {
                Console.WriteLine("{0}{1}|{1}{0}", new string('.', sideDots), new string('x', x));
                sideDots++;
                x--;
            }

            // mid rows
            sideDots = (width - 1) / 2;
            Console.WriteLine("{0}/x\\{0}", new string('.', sideDots - 1));
            Console.WriteLine("{0}\\x/{0}", new string('.', sideDots - 1));

            // bottom part

            //increasing
            x = n;
            sideDots = (width - 1 - 2 * x) / 2;

            for (int i = 0; i < (n + 1) / 2; i++)
            {
                Console.WriteLine("{0}{1}|{1}{0}", new string('.', sideDots), new string('x', x));
                sideDots--;
                x++;
            }

            //decreasing

            x -= 2;
            sideDots = 1;

            for (int i = 0; i < n / 2; i++)
            {
                Console.WriteLine("{0}{1}|{1}{0}", new string('.', sideDots), new string('x', x));
                sideDots++;
                x--;
            }

            //last rows
            sideDots = (width - 1) / 2;
            Console.WriteLine("{0}x|x{0}", new string('.', sideDots - 1)); 
            Console.WriteLine("{0}\\x/{0}", new string('.', sideDots - 1));
            Console.WriteLine("{0}x{0}", new string('.', sideDots));


        }
    }
}
