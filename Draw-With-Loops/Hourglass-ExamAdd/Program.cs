using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hourglass_ExamAdd
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int width = 2 * n + 1;
            int height = 2 * n + 1;
            Console.WriteLine($"{new string('*', width)}"); //first line

            char midSign = '@';
            int sideDots = 1;
            int middle = width - sideDots * 2 - 2;
            for (int row = 1; row <= n - 1; row++)
            {
                if (row == 1) midSign = ' ';
                else midSign = '@';
                Console.WriteLine("{0}*{1}*{0}", new string('.', sideDots), new string(midSign, middle)); //top part
                sideDots++;
                middle -= 2;
            }

            Console.WriteLine("{0}*{0}", new string('.', (width - 1) / 2)); //middle line
            
            sideDots -= 1;
            middle = width - sideDots * 2 - 2;
            int sideMiddle = (middle - 1) / 2;
            for (int row = 0; row < n - 1; row++)
            {
                if (row == n - 2)
                {
                    Console.WriteLine("{0}*{1}@{1}*{0}", new string('.', sideDots), new string('@', sideMiddle)); //top part
                }
                else
                {
                    Console.WriteLine("{0}*{1}@{1}*{0}", new string('.', sideDots), new string(' ', sideMiddle)); //top part
                }
                sideDots--;
                sideMiddle++;
            }
            Console.WriteLine($"{new string('*', width)}"); //last line

        }
    }
}
