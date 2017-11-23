using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetterCombinations_ExamAdd
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstLetter = char.Parse(Console.ReadLine());
            char lastLetter = char.Parse(Console.ReadLine());
            char exceptionLetter = char.Parse(Console.ReadLine());
            int combinations = 0;

            for (char first = firstLetter; first <= lastLetter; first++)
            {
                for (char second = firstLetter; second <= lastLetter; second++)
                {
                    for (char third = firstLetter; third <= lastLetter; third++)
                    {
                        if (first == exceptionLetter || second == exceptionLetter || third == exceptionLetter) continue;
                        Console.Write($"{first}{second}{third} ");
                        combinations++;
                    }
                }
            }
            Console.Write(combinations);
            Console.WriteLine();

        }
    }
}
