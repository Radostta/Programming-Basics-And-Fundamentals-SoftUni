using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadToDeg_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            double rad = double.Parse(Console.ReadLine());
            var deg = rad * 180 / Math.PI;

            Console.WriteLine(Math.Round(deg));

        }
    }
}
