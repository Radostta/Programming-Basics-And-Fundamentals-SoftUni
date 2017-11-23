using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrapezoidAreaBook
{
    class TrapezoidAreaBook
    {
        static void Main(string[] args)
        {
            var a1 = double.Parse(Console.ReadLine());
            var a2 = double.Parse(Console.ReadLine());
            var h = double.Parse(Console.ReadLine());

            var area = (a1 + a2) * h / 2.0;
            Console.WriteLine(area);
        }
    }
}
