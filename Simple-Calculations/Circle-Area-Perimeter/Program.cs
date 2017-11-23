using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle_Area_Perimeter
{
    class Program
    {
        static void Main(string[] args)
        {
            double r = double.Parse(Console.ReadLine());

            Console.WriteLine(Math.PI * r * r);
            Console.WriteLine(Math.PI * 2 * r);


        }
    }
}
