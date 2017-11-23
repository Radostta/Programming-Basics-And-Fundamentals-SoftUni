using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logistics
{
    class Program
    {
        static void Main(string[] args)
        {
            int loadsCount = int.Parse(Console.ReadLine());

            double minibusTonsCount = 0;
            double truckTonsCount = 0;
            double trainTonsCount = 0;
        
            double allLoadsPrice = 0;
        
            for (int currentLoad = 1; currentLoad <= loadsCount; currentLoad++)
            {
                int tonsOfLoad = int.Parse(Console.ReadLine());

                if (tonsOfLoad >=1 && tonsOfLoad <= 3)
                {
                    minibusTonsCount += tonsOfLoad;
                    allLoadsPrice += (tonsOfLoad * 200);
                }
                else if (tonsOfLoad <= 11)
                {
                    truckTonsCount += tonsOfLoad;
                    allLoadsPrice += (tonsOfLoad * 175);
                }
                else if (tonsOfLoad >= 12 && tonsOfLoad <= 1000)
                {
                    trainTonsCount += tonsOfLoad;
                    allLoadsPrice += (tonsOfLoad * 120);
                }
            }

            double allTonsCount = minibusTonsCount + truckTonsCount + trainTonsCount;
            double avrPricePerTon = allLoadsPrice / allTonsCount;

            double minibusPercent = minibusTonsCount / allTonsCount * 100;
            double truckPercent = truckTonsCount / allTonsCount * 100;
            double trainPercent = trainTonsCount / allTonsCount * 100;

            Console.WriteLine($"{avrPricePerTon:f2}");
            Console.WriteLine($"{minibusPercent:f2}%");
            Console.WriteLine($"{truckPercent:f2}%");
            Console.WriteLine($"{trainPercent:f2}%");



        }
    }
}
