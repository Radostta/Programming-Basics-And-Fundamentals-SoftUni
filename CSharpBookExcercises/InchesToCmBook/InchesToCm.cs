using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InchesToCmBook
{
    class InchesToCm
    {
        static void Main(string[] args)
        {
            Console.Write("Inches = ");
            var inches = double.Parse(Console.ReadLine());
            var cm = inches * 2.54;
            Console.Write("Centimeters = ");
            Console.WriteLine(cm);
        }
    }
}
