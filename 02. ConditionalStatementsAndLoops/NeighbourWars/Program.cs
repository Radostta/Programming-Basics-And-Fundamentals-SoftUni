using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeighbourWars
{
    class Program
    {
        static void Main(string[] args)
        {
            int peshosDamage = int.Parse(Console.ReadLine());
            int goshosDamage = int.Parse(Console.ReadLine());
            int peshosHealth = 100;
            int goshosHealth = 100;

            for (int round = 1; round <= 100; round++)
            {
                if (peshosHealth <= 0 || goshosHealth <= 0)
                {
                    if (peshosHealth <= 0)
                    {
                        Console.WriteLine($"Gosho won in {round - 1}th round.");
                    }
                    else if (goshosHealth <= 0)
                    {
                        Console.WriteLine($"Pesho won in {round - 1}th round.");
                    }
                    break;
                }


                if (round % 2 == 0)
                {
                    peshosHealth -= goshosDamage;
                    if (peshosHealth <= 0) continue;
                    Console.WriteLine($"Gosho used Thunderous fist and reduced Pesho to {peshosHealth} health.");
                }
                else
                {
                    goshosHealth -= peshosDamage;
                    if (goshosHealth <= 0) continue;
                    Console.WriteLine($"Pesho used Roundhouse kick and reduced Gosho to {goshosHealth} health.");
                }

                if (round % 3 == 0 && goshosHealth > 0 && peshosHealth > 0)
                {
                    goshosHealth += 10;
                    peshosHealth += 10;                            
                }
            }

        }
    }
}
