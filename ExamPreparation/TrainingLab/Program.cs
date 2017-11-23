using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingLab
{
    class Program
    {
        static void Main(string[] args)
        {
            double length = double.Parse(Console.ReadLine()); //inMeters
            double width = double.Parse(Console.ReadLine()); //inMeters
            width -= 1;
            double lengthInCm = length * 100;
            double widthInCm = width * 100;

            double desksPerRow = Math.Floor((width / 70) * 100);
            double rows = Math.Floor((length / 120) * 100);

            double desks = desksPerRow * rows - 3;
            
            Console.WriteLine(desks);


                

        }
    }
}
