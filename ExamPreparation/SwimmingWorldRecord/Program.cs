using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwimmingWorldRecord
{
    class Program
    {
        static void Main(string[] args)
        {
            double benchmarkTimeInSec = double.Parse(Console.ReadLine());
            double distanceInMeters = double.Parse(Console.ReadLine());
            double speedMetersInSec = double.Parse(Console.ReadLine());

            double ivanTime = distanceInMeters * speedMetersInSec;  // time = distance * speed;
            double plusTime = Math.Floor(distanceInMeters / 15) * 12.5;
            double totalTime = ivanTime + plusTime;

            if (totalTime < benchmarkTimeInSec)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {totalTime:f2} seconds.");
            }
            else
            {
                Console.WriteLine($"No, he failed! He was {(totalTime - benchmarkTimeInSec):f2} seconds slower.");
            }
            



        }
    }
}
