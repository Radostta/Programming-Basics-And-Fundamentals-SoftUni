using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MostFrequentNumber_Original
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int currentNumber = 0;
            int number = 0;            
            bool areDifferent = true;

            int biggestCount = 1;

            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                int currentCount = 1;

                for (int j = i - 1; j >= 0; j--)
                {
                    if (numbers[i] == numbers[j])
                    {
                        currentCount++;
                        currentNumber = numbers[i];
                        areDifferent = false;
                    }
                }
                if (currentCount >= biggestCount)
                {
                    biggestCount = currentCount;
                    number = currentNumber;
                }                
            }

            if (areDifferent)
            {
                Console.WriteLine(numbers[0]);
            }
            else
            {
                Console.WriteLine(number);
            }
        }
    }
}
