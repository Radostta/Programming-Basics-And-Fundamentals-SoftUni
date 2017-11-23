using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariableInHexadecimalFormat
{
    class Program
    {
        static void Main(string[] args)
        {
            string numberHexadecimal = Console.ReadLine();
            int numberDecimal = Convert.ToInt32(numberHexadecimal, 16);
            Console.WriteLine(numberDecimal);
        }
    }
}
