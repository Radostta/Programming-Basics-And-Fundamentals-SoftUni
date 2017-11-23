using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertSpeedUnits
{
    class Program
    {
        static void Main(string[] args)
        {           
            int distanceInMeters = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int seconds = int.Parse(Console.ReadLine());

            float timeInSeconds = seconds + minutes * 60 + hours * 3600;              
            float distanceInMiles = distanceInMeters / 1609f;

            float speedInMetersPerSecond = distanceInMeters / timeInSeconds;
            float speedInKmPerHour = (float)(distanceInMeters * 0.001) / (timeInSeconds / 3600);
            float speedInMilesPerHour = distanceInMiles / (timeInSeconds / 3600);

            Console.WriteLine(speedInMetersPerSecond);
            Console.WriteLine(speedInKmPerHour);
            Console.WriteLine(speedInMilesPerHour);



        }
    }
}
