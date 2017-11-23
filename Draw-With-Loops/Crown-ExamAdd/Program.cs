using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crown_ExamAdd
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int width = (2 * n) - 1;
            int height = (n / 2) + 4;

            Console.WriteLine("@{0}@{0}@", new string(' ', n - 2)); //first line
            Console.WriteLine("**{0}*{0}**", new string(' ', n - 3)); //second line

            //middle part
            int sideDotsCount = 1;
            int midDotsCount = 1;
            int sideSpacesCount = (width - (2 * sideDotsCount) - midDotsCount - 6) / 2;

            for (int row = 1; row <= (n / 2) - 1; row++)
            {
                if (sideSpacesCount <= 0)
                {
                    Console.WriteLine("*{0}*{1}*{0}*", new string('.', sideDotsCount), new string('.', midDotsCount));
                }
                else
                {
                    Console.WriteLine("*{0}*{1}*{2}*{1}*{0}*", new string('.', sideDotsCount), new string(' ', sideSpacesCount), new string('.', midDotsCount));
                }
                sideDotsCount += 1;
                midDotsCount += 2;
                sideSpacesCount -= 2;
            }

            //bottom part
            Console.WriteLine("*{0}{1}.{1}{0}*", new string('.', n / 2), new string('*', (width - n - 3) / 2));
            for (int row = 0; row < 2; row++)
            {
                Console.WriteLine(new string('*', width));
            }
        }
    }
}
