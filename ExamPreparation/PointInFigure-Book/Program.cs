
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointInFigure_Book
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            var isInHorizontal = ((x >= 2 && x <= 12) && (y >= -3 && y <= 1));
            var isInVertical = ((x >= 4 && x <= 10) && (y >= -5 && y <= 3));

            if (isInHorizontal || isInVertical) Console.WriteLine("in");
            else Console.WriteLine("out");
        }
    }
}
