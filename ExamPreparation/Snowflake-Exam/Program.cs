using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snowflake_Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int height = 2 * n + 1;
            int width = 2 * n + 3;

            //Top Part

            for (int i = 0; i < n - 1; i++)
            {
                int dotsAfterStarCount = n - 2 - i;
                string dotsBeforeStar = new string('.', i);
                string dotsAfterStar = new string('.', dotsAfterStarCount);
                Console.WriteLine("{0}*{1}..*..{1}*{0}", dotsBeforeStar, dotsAfterStar);
            }

            //Middle Part
            int dots = (width - 5) / 2;
            Console.WriteLine("{0}*****{0}", new string('.', dots));
            Console.WriteLine(new string('*', width));
            Console.WriteLine("{0}*****{0}", new string('.', dots));

            //Last part

            for (int i = n - 2; i >= 0; i--)
            {
                int dotsAfterStarCount = n - i;
                string dotsBeforeStar = new string('.', i);
                string dotsAfterStar = new string('.', dotsAfterStarCount);
                Console.WriteLine("{0}*{1}*{1}*{0}", dotsBeforeStar, dotsAfterStar);
            }
        }
    }
}
