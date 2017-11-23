using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battles_ExamAdd
{
    class Program
    {
        static void Main(string[] args)
        {
            int player1Count = int.Parse(Console.ReadLine());
            int player2Count = int.Parse(Console.ReadLine());
            int games = int.Parse(Console.ReadLine());
            int turns = 0;

            for (int player1 = 1; player1 <= player1Count; player1++)
            {
                for (int player2 = 1; player2 <= player2Count; player2++)
                {
                    if (turns >= games) break;
                    Console.Write($"({player1} <-> {player2}) ");
                    turns += 1;
                }
            }
            Console.WriteLine();



        }
    }
}
