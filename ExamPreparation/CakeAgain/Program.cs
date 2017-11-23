using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CakeAgain
{
    class Program
    {
        static void Main(string[] args)
        {
            int cakeWidth = int.Parse(Console.ReadLine());
            int cakeLength = int.Parse(Console.ReadLine());

            int totalPieces = cakeLength * cakeWidth;
            int orderedPieces = 0;

            do
            {
                string order = Console.ReadLine();

                if (order == "STOP")
                {
                    break;
                }

                totalPieces -= int.Parse(order);
                orderedPieces += int.Parse(order);
            } while (totalPieces >= 0);

            if (totalPieces < 0)
            {
                Console.WriteLine($"No more cake left! You need {orderedPieces - (cakeLength * cakeWidth)} pieces more.");
            }
            else
            {
                Console.WriteLine($"{totalPieces} pieces are left.");
            }


        }
    }
}
