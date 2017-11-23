using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniLogo_ExamAdd
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int height = 4 * n - 2;
            int width = 12 * n - 5;

            int sideDots = (width - 1) / 2;
            Console.WriteLine("{0}#{0}", new string('.', sideDots)); //first line

            int middle = 7;
            sideDots = sideDots - 3;
            for (int row = 0; row < 2 * n - 1; row++)
            {
                Console.WriteLine("{0}{1}{0}", new string('.', sideDots), new string('#', middle)); //top part
                middle = middle + 6;
                sideDots = sideDots - 3;
            }

            middle = width - 6;
            sideDots = (width - middle) / 2;
            for (int row = 0; row < n-2; row++)
            {
                Console.WriteLine("|{0}{1}{2}", new string('.', sideDots - 1), new string('#', middle), new string('.', sideDots)); //lower part
                middle = middle - 6;
                sideDots = sideDots + 3;
            }

            char first = '|';

            for (int row = 1; row <= n; row++)
            {
                if (row == n) first = '@';
                Console.WriteLine("{0}{1}{2}{3}", first, new string('.', sideDots - 1), new string('#', middle), new string('.', sideDots)); //bottom part               
            }
        }
    }
}
