using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestCommonEnd_Original
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstWords = Console.ReadLine().Split(' ');
            var secondWords = Console.ReadLine().Split(' ');

            var commonLength = Math.Min(firstWords.Length, secondWords.Length);
            
            int leftSum = 0;
            int rightSum = 0;            

            for (int i = 0; i < commonLength; i++)
            {
                if (firstWords[i] == secondWords[i])
                {
                    leftSum++;                    
                }

                if (firstWords[firstWords.Length - 1 - i] == secondWords[secondWords.Length - 1 - i])
                {
                    rightSum++;                    
                }
            }

            int bestSum = Math.Max(leftSum, rightSum);
            Console.WriteLine(bestSum);

        }
    }
}
