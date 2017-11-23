using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadiansToDegreesBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var rad = double.Parse(Console.ReadLine());
            Console.WriteLine(Math.Round(rad * 180 / Math.PI));
        }
    }
}
