using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateTriangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double side = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            double area = GetTriangleArea(side, height);

            Console.WriteLine(area);

        }

        static double GetTriangleArea(double side, double height)
        {
            return (side * height / 2);
        }
    }
}
