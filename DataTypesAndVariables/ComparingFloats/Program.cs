using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparingFloats
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            double epsilon = 0.000001;
            double difference = Math.Abs(num1 - num2);
            bool areEqual = true;

            if (difference >= epsilon)
            {
                areEqual = false;
            }

            Console.WriteLine(areEqual);
        }
    }
}
