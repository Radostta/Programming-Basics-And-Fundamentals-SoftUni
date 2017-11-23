using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChristmasHat_Book
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int width = 4 * n + 1;
            int height = 2 * n + 5;
            Console.WriteLine("{0}/|\\{0}", new string('.', 2 * n - 1));
            Console.WriteLine("{0}\\|/{0}", new string('.', 2 * n - 1));
            Console.WriteLine("{0}***{0}", new string('.', 2 * n - 1));

            int midDashes = 1;
            int sideDots = (width - midDashes * 2 - 3) / 2;
            for (int i = 1; i < 2 * n; i++)
            {
                Console.WriteLine("{0}*{1}*{1}*{0}", new string('.', sideDots), new string('-', midDashes));
                sideDots--;
                midDashes++;
            }
           

            Console.WriteLine(new string('*', width));
            for (int i = 0; i < width / 2; i++)
            {
                Console.Write("*.");               
            }
            Console.Write("*");
            Console.WriteLine();
            Console.WriteLine(new string('*', width));


        }
    }
}
