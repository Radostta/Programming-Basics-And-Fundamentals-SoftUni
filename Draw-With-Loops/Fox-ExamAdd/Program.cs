using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fox_ExamAdd
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int width = 2 * n + 3;

            int sideStars = 1;
            int middle = width - 2 * sideStars - 2;

            for (int row = 0; row < n; row++)
            {
                Console.WriteLine("{0}\\{1}/{0}", new string('*', sideStars), new string('-', middle)); //top part
                sideStars++;
                middle = middle - 2;
            }

            //mid part            
            
            middle = n;
            sideStars = (width - middle - 4) / 2;
            for (int row = 0; row < n / 3; row++)
            {
                Console.WriteLine("|{0}\\{1}/{0}|", new string('*', sideStars), new string('*', middle));
                sideStars++;
                middle = middle - 2;
            }
            

            //bottom part
            for (int sideDashes = 1; sideDashes <= n; sideDashes++)
            {
                int middleStars = width - 2 * sideDashes - 2;
                Console.WriteLine("{0}\\{1}/{0}", new string('-', sideDashes), new string('*', middleStars));
                middleStars = middleStars - 2;
            }
            
            

        }
    }
}
