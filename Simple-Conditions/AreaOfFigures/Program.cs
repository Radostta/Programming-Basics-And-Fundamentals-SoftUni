using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaOfFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            var figure = Console.ReadLine();
            string square = "square";
            string rectangle = "rectangle";
            string circle = "circle";
            string triangle = "triangle";

            if (figure == "square")
            {
                double squareSide = double.Parse(Console.ReadLine());
                var squareArea = squareSide * squareSide;
                Console.WriteLine("{0:f3}", squareArea);
            }
            else if (figure == "rectangle")
            {
                double recSide1 = double.Parse(Console.ReadLine());
                double recSide2 = double.Parse(Console.ReadLine());
                var rectangleArea = recSide1 * recSide2;
                Console.WriteLine("{0:f3}", rectangleArea);
            }
            else if (figure == "circle")
            {
                double circleRadius = double.Parse(Console.ReadLine());
                var circleArea = Math.PI * circleRadius * circleRadius;
                Console.WriteLine("{0:f3}", circleArea);
            }
            else if (figure == "triangle")
            {
                double triSide = double.Parse(Console.ReadLine());
                double triHeight = double.Parse(Console.ReadLine());
                var triangleArea = 0.5 * triSide * triHeight;
                Console.WriteLine($"{triangleArea:f3}");
            }

        }
    }
}
