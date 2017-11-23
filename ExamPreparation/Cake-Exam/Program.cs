using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cake_Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int cakeWidth = int.Parse(Console.ReadLine());
            int cakeHeight = int.Parse(Console.ReadLine());

            int totalPieces = cakeWidth * cakeHeight;
            int piecesTaken = 0;

            string input = Console.ReadLine();

            while (input != "STOP") //or instead of if {} (input != "STOP" && piecesTaken <= totalPieces) -> but it has to be && (not ||) and <= (not <)
            {
                int taken = int.Parse(input);
                piecesTaken += taken;

                if (piecesTaken > totalPieces)
                {
                    break;
                }

                input = Console.ReadLine();
            }

            if (piecesTaken > totalPieces)
            {
                Console.WriteLine($"No more cake left! You need {piecesTaken - totalPieces} pieces more.");
            }
            else
            {
                Console.WriteLine($"{totalPieces - piecesTaken} pieces are left.");
            }
        }
    }
}
