using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rocket_ExamAdd
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int width = 3 * n;
            int middle = 0;
            int sideDots = (width - middle - 2) / 2;

            for (int row = 0; row < n; row++)
            {
                Console.WriteLine("{0}/{1}\\{0}", new string('.', sideDots), new string(' ', middle)); //top part
                middle = middle + 2;
                sideDots--;
            }

            Console.WriteLine("{0}{1}{0}", new string('.', sideDots + 1), new string('*', middle)); //line below top

            for (int row = 0; row < 2 * n; row++)
            {
                Console.WriteLine("{0}|{1}|{0}", new string('.', sideDots + 1), new string('\\', middle - 2)); //middle part
            }

            for (int row = 0; row < n / 2; row++)
            {
                Console.WriteLine("{0}/{1}\\{0}", new string('.', sideDots + 1), new string('*', middle - 2));
                middle = middle + 2;
                sideDots--;
            }

        }
    }
}
