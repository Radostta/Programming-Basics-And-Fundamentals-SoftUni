using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            double rectangeWidth = double.Parse(Console.ReadLine());
            double rectangeHeight = double.Parse(Console.ReadLine());

            double rectanglePerimeter = 2 * rectangeWidth + 2 * rectangeHeight;
            double rectangleArea = rectangeWidth * rectangeHeight;       
            double rectangleDiagonal = Math.Sqrt(rectangeWidth * rectangeWidth + rectangeHeight * rectangeHeight);           

            Console.WriteLine($"{rectanglePerimeter}\n{rectangleArea}\n{rectangleDiagonal}");
        }
    }
}
