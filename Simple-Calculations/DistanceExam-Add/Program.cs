using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceExam_Add
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal initialSpeed = decimal.Parse(Console.ReadLine());
            decimal initialTimeMins = decimal.Parse(Console.ReadLine());
            decimal accelTimeMins = decimal.Parse(Console.ReadLine());
            decimal slowTimeMins = decimal.Parse(Console.ReadLine());

            decimal accelSpeed = initialSpeed + initialSpeed * 10m / 100m;
            decimal slowSpeed = accelSpeed - accelSpeed * 5m / 100m;

            decimal initialKm = (initialTimeMins / 60m) * initialSpeed;
            decimal accelKm = (accelTimeMins / 60m) * accelSpeed;
            decimal slowKm = (slowTimeMins / 60m) * slowSpeed;

            decimal distance = initialKm + accelKm + slowKm;

            Console.WriteLine($"{distance:f2}");






        }
    }
}
