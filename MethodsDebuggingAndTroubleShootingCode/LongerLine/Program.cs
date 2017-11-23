using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongerLine
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = 0.0;
            double y1 = 0.0;
            double x2 = 0.0;
            double y2 = 0.0;

            double maxLineLength = double.MinValue;
            double x1Max = double.MinValue;
            double y1Max = double.MinValue;
            double x2Max = double.MinValue;
            double y2Max = double.MinValue;

            for (int i = 0; i < 2; i++)
            {
                x1 = double.Parse(Console.ReadLine());
                y1 = double.Parse(Console.ReadLine());

                x2 = double.Parse(Console.ReadLine());
                y2 = double.Parse(Console.ReadLine());

                double line = FindLine(x1, x2, y1, y2);

                if (line > maxLineLength)
                {
                    maxLineLength = line;
                    x1Max = x1;
                    y1Max = y1;
                    x2Max = x2;
                    y2Max = y2;
                }
            }

            PrintResult(x1Max, x2Max, y1Max, y2Max);
        }

        static void PrintResult (double x1, double x2, double y1, double y2)
        {
            double distanceOne = Math.Sqrt((x1 * x1) + (y1 * y1));
            double distanceTwo = Math.Sqrt((x2 * x2) + (y2 * y2));

            if (distanceTwo < distanceOne)
            {
                Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
            }
            else
            {
                Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
            }
        }

        static double FindLine(double x1, double x2, double y1, double y2)
        {
            return Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
        }
    }
}
