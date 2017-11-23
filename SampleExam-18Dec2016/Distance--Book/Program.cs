using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distance__Book
{
    class Program
    {
        static void Main(string[] args)
        {
            double speed = double.Parse(Console.ReadLine());
            double initialMinutes = double.Parse(Console.ReadLine());
            double afterAccelMinutes = double.Parse(Console.ReadLine());
            double afterSlowMinutes = double.Parse(Console.ReadLine());

            double initialKm = speed * (initialMinutes / 60.00);
            speed += speed * 0.10;
            double accelKm = speed * (afterAccelMinutes / 60.00);
            speed -= speed * 0.05;
            double slowKm = speed * (afterSlowMinutes / 60.00);
            double km = initialKm + accelKm + slowKm;
            Console.WriteLine($"{km:f2}");


        }
    }
}
