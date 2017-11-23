using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            var area = a * h / 2;

            // Console.WriteLine(Math.Round(area, 2));

            // Console.WriteLine("{0:f2}", area);

            Console.WriteLine($"{area:f2}");

        }
    }
}
