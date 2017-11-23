using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointInTheFigure
{
    class Program
    {
        static void Main(string[] args)
        {
            var h = int.Parse(Console.ReadLine());
            var x = int.Parse(Console.ReadLine());
            var y = int.Parse(Console.ReadLine());

            var x1 = 0.0;
            var y1 = 0.0;
            var x2 = 3 * h;
            var y2 = h;
            var x3 = h;
            var y3 = h;
            var x4 = 2 * h;
            var y4 = 4 * h;

            var insideRect12 = ((x > x1 && x < x2 && y > 0 && y < y2) || (y == y2 && x > x3 && x < x4));
            var insideRect34 = (x > x3 && x < x4 && y > y3 && y < y4);
            var border12 = (((x == x1 || x == x2) && (y >= y1 && y <= y2)) ||
                ((y == y1 || y == y2) && (x >= x1 && x <= x2)));
            var border34 = (((x == x3 || x == x4) && (y >= y3 && y <= y4)) ||
                ((y == y3 || y == y4) && (x >= x3 && x <= x4)));

            if (insideRect12 || insideRect34)
            {
                Console.WriteLine("inside");
            }
            else if (border12 || border34)
            {
                Console.WriteLine("border");
            }
            else
            {
                Console.WriteLine("outside");
            }

        }
    }
}
