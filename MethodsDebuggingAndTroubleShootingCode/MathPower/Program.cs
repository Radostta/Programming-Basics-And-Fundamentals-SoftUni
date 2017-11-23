using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathPower
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());
            var numberPower = CalcPower(number, power);

            Console.WriteLine(numberPower);
        }

        static double CalcPower(double number, int power)
        {
            //double result = Math.Pow(number, power);
            double result = 1;
            for (int i = 1; i <= power; i++)
            {
                result = result * number;
            }
            return result;
        }

        
    }
}
