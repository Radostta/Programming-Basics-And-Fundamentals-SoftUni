using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanceHall_ExamAdd
{
    class Program
    {
        static void Main(string[] args)
        {
            double l = double.Parse(Console.ReadLine());
            double w = double.Parse(Console.ReadLine());
            double a = double.Parse(Console.ReadLine());

            double hallArea = l * w;
            double wardrobeArea = a * a;
            double benchArea = hallArea / 10;

            double freeSpace = hallArea - wardrobeArea - benchArea;
            double dancers = freeSpace / 0.704;

            Console.WriteLine($"{Math.Truncate(dancers)}");
        }
    }
}
