using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawFort
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int width = 2 * n;
            int height = n;
            int insideColumn = n / 2;

            int bridge = width - insideColumn * 2 - 4;

            Console.WriteLine("/{0}\\{1}/{0}\\", new string('^', insideColumn), new string('_', bridge)); //first line

            for (int i = 1; i <= n - 2; i++)
            {
                if (i == n - 2) Console.WriteLine("|{0}{1}{0}|", new string(' ', insideColumn + 1), new string('_', bridge));
                else Console.WriteLine($"|{new string(' ', width - 2)}|");
            }

            Console.WriteLine("\\{0}/{1}\\{0}/", new string('_', insideColumn), new string(' ', bridge)); //last line

        }
    }
}
