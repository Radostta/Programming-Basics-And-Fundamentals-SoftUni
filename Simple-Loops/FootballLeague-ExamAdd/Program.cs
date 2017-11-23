using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballLeague_ExamAdd
{
    class Program
    {
        static void Main(string[] args)
        {
            double stadiumMax = double.Parse(Console.ReadLine());
            double fanCount = double.Parse(Console.ReadLine());
            double sectorA = 0.00;
            double sectorB = 0.00;
            double sectorV = 0.00;
            double sectorG = 0.00;

            for (int currentFan = 0; currentFan < fanCount; currentFan++)
            {
                string sector = Console.ReadLine();

                if (sector == "A")
                {
                    sectorA++;
                }
                else if (sector == "B")
                {
                    sectorB++;
                }
                else if (sector == "V")
                {
                    sectorV++;
                }
                else if (sector == "G")
                {
                    sectorG++;
                }
            }

            double percentA = sectorA / fanCount * 100.00;
            double percentB = sectorB / fanCount * 100.00;
            double percentV = sectorV / fanCount * 100.00;
            double percentG = sectorG / fanCount * 100.00;
            double percentFans = fanCount / stadiumMax * 100.00;

            Console.WriteLine($"{percentA:f2}%");
            Console.WriteLine($"{percentB:f2}%");
            Console.WriteLine($"{percentV:f2}%");
            Console.WriteLine($"{percentG:f2}%");
            Console.WriteLine($"{percentFans:f2}%");

        }
    }
}
