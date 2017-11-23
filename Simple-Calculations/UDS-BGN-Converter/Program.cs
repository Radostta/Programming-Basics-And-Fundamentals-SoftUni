using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UDS_BGN_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal USD = decimal.Parse(Console.ReadLine());

            decimal BGN = USD * 1.79549m;

            Console.WriteLine(Math.Round(BGN, 2));

        }
    }
}
