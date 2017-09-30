using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicLetter
{
    class Program
    {
        static void Main(string[] args)
        {
            char start = char.Parse(Console.ReadLine());
            char finish = char.Parse(Console.ReadLine());
            char exception = char.Parse(Console.ReadLine());

            for (char l1 = start; l1 <= finish; l1++)
            {
                for (char l2 = start; l2 <= finish; l2++)
                {
                    for (char l3 = start; l3 <= finish; l3++)
                    {
                        if (l1 == exception || l2 == exception || l3 == exception)
                        {
                            continue;
                        }
                        Console.Write($"{l1}{l2}{l3} ");
                    }
                }
            }

        }
    }
}
