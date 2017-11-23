using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StupidPasswordGenerator_Book
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var l = int.Parse(Console.ReadLine());

            for (int first = 1; first <= n; first++)
            {
                for (int second = 1; second <= n; second++)
                {
                    for (var third = 'a'; third < 'a' + l; third++)
                    {
                        for (var forth = 'a'; forth < 'a' + l; forth++)
                        {
                            for (int fifth = Math.Max(first, second) + 1; fifth <= n; fifth++)
                            {
                                Console.Write($"{first}{second}{third}{forth}{fifth} ");
                            }
                        }
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
