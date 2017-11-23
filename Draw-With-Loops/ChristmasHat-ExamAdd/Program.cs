using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChristmasHat_ExamAdd
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int width = 4 * n + 1;
            int height = 2 * n + 5;
            int middle1 = 0;
            int middle2 = 0;
            int sideDots = (width - middle1 - middle2 - 3) / 2;

            Console.WriteLine("{0}/{1}|{2}\\{0}", new string('.', sideDots), new string('-', middle1), new string('-', middle2)); //first row
            Console.WriteLine("{0}\\{1}|{2}/{0}", new string('.', sideDots), new string('-', middle1), new string('-', middle2)); //second row

            for (int row = 0; row < n * 2; row++)
            {
                Console.WriteLine("{0}*{1}*{2}*{0}", new string('.', sideDots), new string('-', middle1), new string('-', middle2)); //top part
                middle1++;
                middle2++;
                sideDots--;
            }

            //bottom part
            Console.WriteLine("{0}", new string('*', width));

            for (int i = 0; i < (width - 1) / 4; i++)
            {
                Console.Write("*.");
            }
            Console.Write('*');
            for (int i = 0; i < (width - 1) / 4; i++)
            {
                Console.Write(".*");
            }
            Console.WriteLine();

            Console.WriteLine("{0}", new string('*', width));

        }
    }
}
