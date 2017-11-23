using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxSequenceOfIncreasingElements_Original
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var length = 1;
            var bestLength = 0;
            var bestIndex = 0;

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > numbers[i - 1]) //we compare the current with previous element (otherwise we'll be out of bounds of the array)
                {
                    length++;
                }
                else
                {
                    length = 1;
                }
                if (length > bestLength)
                {
                    bestLength = length;
                    bestIndex = i - length + 1; //returns to the index at the start of the sequence
                }
            }

            //Printing the result:
            for (int i = bestIndex; i < bestIndex + bestLength; i++)
            {
                Console.Write(numbers[i] + " ");
            }
        }
    }
}
