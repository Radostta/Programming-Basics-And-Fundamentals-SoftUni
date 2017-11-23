using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetterCombinations_Book
{
    class Program
    {
        static void Main(string[] args)
        {
            char start = char.Parse(Console.ReadLine());
            char finish = char.Parse(Console.ReadLine());
            char exception = char.Parse(Console.ReadLine());
            int combinations = 0;

            for (char letter1 = start; letter1 <= finish; letter1++)
            {
                for (char letter2 = start; letter2 <= finish; letter2++)
                {
                    for (char letter3 = start; letter3 <= finish; letter3++)
                    {
                        if (letter1 == exception || letter2 == exception || letter3 == exception) continue;
                        Console.Write($"{letter1}{letter2}{letter3} ");
                        combinations++;
                    }
                }
            }
            Console.WriteLine(combinations);
        }
    }
}
