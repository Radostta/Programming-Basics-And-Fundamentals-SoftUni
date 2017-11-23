using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1SimpleCalculations
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double percentage = double.Parse(Console.ReadLine());

            double volume = length * width * height;
            double liters = volume * 0.001;
            double percent = percentage * 0.01;
            double percentLeft = 1 - percent;
            double actualLiters = liters * percentLeft;
            

            Console.WriteLine($"{actualLiters:f3}");

            



        }
    }
}
