using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousePainting_Exam_Add
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine()); //house height
            double y = double.Parse(Console.ReadLine()); //house lenght
            double h = double.Parse(Console.ReadLine()); //roof triangle side height

            double doorArea = 1.2 * 2;
            double frontandBackArea = ((x * x) * 2) - doorArea;
            double windowsArea = (1.5 * 1.5) * 2;
            double rearWallsArea = ((x * y) * 2) - windowsArea;

            double roofArea = ((x * y) * 2) + ((x * h / 2) * 2);
            double houseArea = frontandBackArea + rearWallsArea;

            double greenPaint = houseArea / 3.40;
            double redPaint = roofArea / 4.30;

            Console.WriteLine($"{greenPaint:f2}");
            Console.WriteLine($"{redPaint:f2}");




        }
    }
}
