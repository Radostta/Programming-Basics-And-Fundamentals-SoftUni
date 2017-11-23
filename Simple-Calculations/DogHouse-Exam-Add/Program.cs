using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogHouse_Exam_Add
{
    class Program
    {
        static void Main(string[] args)
        {
            double sideA = double.Parse(Console.ReadLine());
            double heightB = double.Parse(Console.ReadLine());

            double leftAndRightSideArea = (sideA * sideA / 2) * 2;

            double backSideArea = ((sideA / 2) * (sideA / 2)) + ((sideA / 2 * (heightB - sideA / 2)) / 2);
            double entryArea = (sideA / 5) * (sideA / 5);

            double frontAndBackSideArea = backSideArea * 2 - entryArea;

            double roofArea = leftAndRightSideArea;
            double houseArea = leftAndRightSideArea + frontAndBackSideArea;

            double greenPaint = houseArea / 3.00;
            double redPaint = roofArea / 5.00;

            Console.WriteLine($"{greenPaint:f2}");
            Console.WriteLine($"{redPaint:f2}");






        }
    }
}
