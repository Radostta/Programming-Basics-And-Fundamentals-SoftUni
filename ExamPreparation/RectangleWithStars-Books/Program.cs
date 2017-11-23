using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleWithStars_Books
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(new string('%', n * 2));
            int rowsCount = n;
            if (n % 2 == 0) rowsCount = n - 1;

            for (int row = 0; row < rowsCount; row++)
            {
                if (rowsCount / 2 == row) Console.Write("%{0}**{0}%", new string(' ', n - 2));
                else Console.Write("%{0}%", new string(' ', 2 * n - 2));
                Console.WriteLine();
            }

            Console.WriteLine(new string('%', n * 2));

        }
    }
}
