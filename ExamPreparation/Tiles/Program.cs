
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tiles
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal side = decimal.Parse(Console.ReadLine());
            decimal tileWidth = decimal.Parse(Console.ReadLine());
            decimal tileLength = decimal.Parse(Console.ReadLine());
            decimal benchWidth = decimal.Parse(Console.ReadLine());
            decimal benchLength = decimal.Parse(Console.ReadLine());

            decimal benchArea = benchWidth * benchLength;
            decimal playgroundArea = side * side - benchArea;
            decimal tileArea = tileWidth * tileLength;
            decimal numberTiles = playgroundArea / tileArea;
            decimal time = numberTiles * 0.2m;

            Console.WriteLine($"{numberTiles:f2}");
            Console.WriteLine($"{time:f2}");


        }
    }
}
