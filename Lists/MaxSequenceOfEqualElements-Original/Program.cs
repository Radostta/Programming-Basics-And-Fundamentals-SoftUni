using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxSequenceOfEqualElements_Original
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            var count = 1;
            var maxCount = 0;            
            var number = 0;

            for (int i = 0; i < numbers.Count - 1; i++)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    count++;
                    if (count > maxCount)
                    {
                        maxCount = count;
                        number = numbers[i];
                    }
                }
                else
                {
                    count = 1;
                }                                               
            }

            if (maxCount == 0)
            {
                Console.WriteLine(numbers[0]);
            }
            else
            {
                for (int i = 0; i < maxCount; i++)
                {
                    Console.Write(number + " ");
                }
                Console.WriteLine();
            }
            
        }
    }
}
