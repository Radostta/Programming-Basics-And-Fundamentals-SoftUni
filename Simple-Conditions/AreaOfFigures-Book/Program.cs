using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaOfFigures_Book
{
    class Program
    {
        static void Main(string[] args)
        {
            var figure = Console.ReadLine().ToLower();
            if (figure == "square")
            {
                var squareSide = double.Parse(Console.ReadLine());
                Console.WriteLine(squareSide * squareSide);
            }
            else if (figure == "rectangle")
            {
                var rectangleSide1 = double.Parse(Console.ReadLine());
                var rectangleSide2 = double.Parse(Console.ReadLine());
                Console.WriteLine(rectangleSide1 * rectangleSide2);
            }
            else if (figure == "circle")
            {
                var radius = double.Parse(Console.ReadLine());
                Console.WriteLine(Math.PI * radius * radius);
            }
            else if (figure == "triangle")
            {
                var triangleSide = double.Parse(Console.ReadLine());
                var height = double.Parse(Console.ReadLine());
                Console.WriteLine(0.5 * triangleSide * height);
            }

           
        }
    }
}
