using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyLoss_ExamAdd
{
    class Program
    {
        static void Main(string[] args)
        {
            double daysCount = double.Parse(Console.ReadLine());
            double dancers = double.Parse(Console.ReadLine());
            double energyAvailable = dancers * 100 * daysCount;
            double energyBurned = 0.00;

            for (int currentDay = 1; currentDay <= daysCount; currentDay++)
            {
                double hours = double.Parse(Console.ReadLine());

                if (currentDay % 2 == 0 && hours % 2 == 0)
                {
                    energyBurned += dancers * 68.00;
                }
                else if (currentDay % 2 == 0)
                {
                    energyBurned += dancers * 65.00;
                }
                else if (hours % 2 == 0)
                {
                    energyBurned += dancers * 49.00;
                }
                else
                    energyBurned += dancers * 30.00;
                }

            double energyLeft = energyAvailable - energyBurned;
            double energyLeftPerDancer = energyLeft / dancers / daysCount;
            double avrEnergyLoss = energyBurned / energyAvailable * 100;     

            if (avrEnergyLoss <= 50)
            {
                Console.WriteLine($"They feel good! Energy left: {energyLeftPerDancer:f2}");
            }
            else
            {
                Console.WriteLine($"They are wasted! Energy left: {energyLeftPerDancer:f2}");
            }
            }
        }
    }

