using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snowflake
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int height = 2 * n + 1;
            int width = 2 * n + 3;
            int sideDots = 0;
            //int midDots = n;

            for (int midDots = n; midDots > 1; midDots--)
            {
                Console.WriteLine("{0}*{1}*{1}*{0}", new string('.', sideDots), new string('.', midDots));
                sideDots++;
                if (midDots == 2) Console.WriteLine("{0}{1}*{1}{0}", new string('.', sideDots), new string('*', midDots));
            }
            Console.WriteLine(new string('*', width));

            for (int midDots = 1; midDots <= n; midDots++)
            {
                if (midDots == 1) Console.WriteLine("{0}*{1}*{1}*{0}", new string('.', sideDots), new string('*', midDots));       
                else Console.WriteLine("{0}*{1}*{1}*{0}", new string('.', sideDots), new string('.', midDots));
                sideDots--;
            }
            
        }
    }
}
