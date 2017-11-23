using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanceHall
{
    class Program
    {
        static void Main(string[] args)
        {
            double hallLength = double.Parse(Console.ReadLine());
            double hallWidth = double.Parse(Console.ReadLine());
            double wardrobeSide = double.Parse(Console.ReadLine());

            double hallArea = (hallLength * 100) * (hallWidth * 100);
            double wardrobeArea = (wardrobeSide * 100) * (wardrobeSide * 100);
            double benchArea = hallArea / 10;
            double freeSpace = hallArea - wardrobeArea - benchArea;

            double dancers = Math.Floor(freeSpace / (7000 + 40));
            Console.WriteLine(dancers);
            



        }
    }
}
