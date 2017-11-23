using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareCharArrays_Original
{
    class Program
    {
        static void Main(string[] args)
        {           
            char[] firstArray = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            char[] secondArray = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();

            var smallerLength = Math.Min(firstArray.Length, secondArray.Length);
            bool isFirstPrior = true;

            for (int i = 0; i < smallerLength; i++)
            {
                if (secondArray[i] < firstArray[i])
                {
                    isFirstPrior = false;
                }
            }

            //Print:
            if (isFirstPrior && smallerLength == firstArray.Length)
            {
                Console.WriteLine(String.Join("", firstArray));
                Console.WriteLine(String.Join("", secondArray));
            }
            else
            {
                Console.WriteLine(String.Join("", secondArray));
                Console.WriteLine(String.Join("", firstArray));
            }
        }
    }
}
