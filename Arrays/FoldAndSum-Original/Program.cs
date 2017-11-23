using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoldAndSum_Original
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int k = numbers.Length / 4;

            int[] leftArray = numbers.Take(k).ToArray(); // .Take(n) takes the first n elements in the array
            int[] midArray = numbers.Skip(k).Take(k * 2).ToArray(); // .Skip skips n elements before take
            int[] rightArray = numbers.Skip(k * 3).Take(k).ToArray();

            Array.Reverse(leftArray); // Array.Reverse(); reverses an array. Now we need to join them
            Array.Reverse(rightArray);

            // int[] upperArray = leftArray.Concat(rightArray).ToArray();

            //Initialize the final sum array:
            int[] resultArray = new int[midArray.Length]; //or [k * 2]

            //Sum left and right elements with middle array:
            for (int i = 0; i < k; i++) // itirating only to k as this is the smallest length of the arrays
            {
                resultArray[i] = midArray[i] + leftArray[i];
                resultArray[i + k] = midArray[i + k] + rightArray[i]; //the first element of the right array starts after k - so it is with index i + k
            }

            Console.WriteLine(string.Join(" ", resultArray));
        }
    }
}
