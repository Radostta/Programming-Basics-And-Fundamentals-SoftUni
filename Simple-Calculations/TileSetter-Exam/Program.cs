using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TileSetter_Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            var playgroundSideN = double.Parse(Console.ReadLine());
            var tileW = double.Parse(Console.ReadLine());
            var tileL = double.Parse(Console.ReadLine());
            var benchWiM = double.Parse(Console.ReadLine());
            var benchLeO = double.Parse(Console.ReadLine());

            var playgroundArea = playgroundSideN * playgroundSideN;
            var tileArea = tileW * tileL;
            var benchArea = benchWiM * benchLeO;

            var space = playgroundArea - benchArea;
            var numberTiles = space / tileArea;
            var time = numberTiles * 0.2;

            Console.WriteLine(numberTiles);
            Console.WriteLine(time);


        }
    }
}
