using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointInTheFigure_Book
{
    class Program
    {
        static void Main(string[] args)
        {
            //ERROR:
            var h = int.Parse(Console.ReadLine());
            var x = int.Parse(Console.ReadLine());
            var y = int.Parse(Console.ReadLine());

            var outRect1 = (x < 0 || x > 3 * h) || (y < 0 || y > h);
            var outRect2 = (x < h || x > 2 * h) || (y < 0 || y > 4 * h);

            var inRect1 = (x > 0 && x < 3 * h) && (y > 0 && y < h);
            var inRect2 = (x > h && x < 2 * h) && (y > 0 && y < 4 * h);

            var commonBorder = (x > h && x < 2 * h) && (y == h);

            if (outRect1 || outRect2)
            {
                Console.WriteLine("outside");
            }
            else if (inRect1 || inRect2 || commonBorder)
            {
                Console.WriteLine("inside");
            }
            else
            {
                Console.WriteLine("border");
            }

        }
    }
}
