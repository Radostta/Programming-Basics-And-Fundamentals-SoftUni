using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstIntegers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var secondIntegers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var maxLength = Math.Max(firstIntegers.Length, secondIntegers.Length);
            var sumOfIndexes = new int[maxLength];

            for (int i = 0; i < sumOfIndexes.Length; i++)
            {
                sumOfIndexes[i] = firstIntegers[i % firstIntegers.Length] + secondIntegers[i % secondIntegers.Length];
            }

            Console.WriteLine(String.Join(" ", sumOfIndexes));
        }
    }
}
