using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleRadiusBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter circle radius. r = ");
            var r = double.Parse(Console.ReadLine());
            //Console.WriteLine("Area = " + Math.PI * r * r);
            //Console.WriteLine("Perimeter = " + 2 * Math.PI * r);

            Console.WriteLine($"Area = {Math.PI * r * r}");
            Console.WriteLine("Perimeter = {0}", 2 * Math.PI * r);

        }
    }
}
