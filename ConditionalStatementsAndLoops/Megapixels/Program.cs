using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Megapixels
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal pictureWidth = decimal.Parse(Console.ReadLine());
            decimal pictureHeight = decimal.Parse(Console.ReadLine());

            decimal picturesPixels = (pictureWidth * pictureHeight) / 1000000;

            Console.WriteLine($"{pictureWidth}x{pictureHeight} => {Math.Round(picturesPixels, 1)}MP");

        }
    }
}
