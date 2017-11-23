using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogisticsExam_Add
{
    class Program
    {
        static void Main(string[] args)
        {
            int loadsCount = int.Parse(Console.ReadLine());
            double totalTons = 0.00;
            double TonsExpense = 0.00;
            double minibusTons = 0.00;
            double truckTons = 0.00;
            double trainTons = 0.00;

            for (int currentLoad = 1; currentLoad <= loadsCount; currentLoad++)
            {
                double currentTons = double.Parse(Console.ReadLine());
                if (currentTons >= 1 && currentTons <= 3)
                {
                    TonsExpense += 200.00 * currentTons;
                    totalTons += currentTons;
                    minibusTons += currentTons;
                }
                else if (currentTons <= 11)
                {
                    TonsExpense += 175.00 * currentTons;
                    totalTons += currentTons;
                    truckTons += currentTons;
                }
                else if (currentTons >= 12 && currentTons <= 1000)
                {
                    TonsExpense += 120.00 * currentTons;
                    totalTons += currentTons;
                    trainTons += currentTons;
                }
            }
            double avrPricePerTon = TonsExpense / totalTons;
            double minibusPercent = minibusTons / totalTons * 100.00;
            double truckPercent = truckTons / totalTons * 100.00;
            double trainPercent = trainTons / totalTons * 100.00;

            Console.WriteLine($"{avrPricePerTon:f2}");
            Console.WriteLine($"{minibusPercent:f2}%");
            Console.WriteLine($"{truckPercent:f2}%");
            Console.WriteLine($"{trainPercent:f2}%");




        }
    }
}
