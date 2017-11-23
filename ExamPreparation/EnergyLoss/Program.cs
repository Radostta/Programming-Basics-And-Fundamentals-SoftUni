using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyLoss
{
    class Program
    {
        static void Main(string[] args)
        {
            double days = double.Parse(Console.ReadLine());
            double dancers = double.Parse(Console.ReadLine());
            double energy = dancers * 100 * days;
            double energyLoss = 0;

            for (int currentDay = 1; currentDay <= days; currentDay++)
            {
                int hoursPerDay = int.Parse(Console.ReadLine());

                if (currentDay % 2 == 0 && hoursPerDay % 2 == 0)
                {
                    energyLoss += (dancers * 68);
                }
                else if (currentDay % 2 != 0 && hoursPerDay % 2 == 0)
                {
                    energyLoss += (dancers * 49);
                }
                else if (currentDay % 2 == 0 && hoursPerDay % 2 != 0)
                {
                    energyLoss += (dancers * 65);
                }
                else if (currentDay % 2 != 0 && hoursPerDay % 2 != 0)
                {
                    energyLoss += (dancers * 30);
                }
            }

            double energyLeft = energy - energyLoss;
            double energyLeftPerDancer = energyLeft / dancers / days;

            if (energyLeftPerDancer >= 50)
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
