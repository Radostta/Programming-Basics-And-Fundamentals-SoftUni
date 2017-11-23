using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousePainting
{
    class Program
    {
        static void Main(string[] args)
        {
            double houseHeight = double.Parse(Console.ReadLine());
            double houseLength = double.Parse(Console.ReadLine());
            double roofHeight = double.Parse(Console.ReadLine());

            double doorArea = 1.2 * 2;
            double frontAndBackArea = (houseHeight * houseHeight) * 2 - doorArea;
            double windowArea = 1.5 * 1.5;
            double leftAndRightArea = (houseHeight * houseLength - windowArea) * 2;
            double houseArea = frontAndBackArea + leftAndRightArea;

            double roofSidesArea = (houseHeight * houseLength) * 2;
            double roofTrianglesArea = (houseHeight * roofHeight / 2) * 2;
            double roofArea = roofSidesArea + roofTrianglesArea;

            double greenPaint = houseArea / 3.4;
            double redPaint = roofArea / 4.3;

            Console.WriteLine($"{greenPaint:f2}");
            Console.WriteLine($"{redPaint:f2}");

        }
    }
}
