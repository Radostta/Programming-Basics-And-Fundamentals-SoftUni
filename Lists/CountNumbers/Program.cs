using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToList();

            if (numbers.Count > 0) //if the list is not empty
            {
                numbers.Sort();
                numbers.Add(int.MaxValue);

                var previous = numbers[0]; //the first element
                var count = 1;

                for (int i = 1; i < numbers.Count; i++) //comparing each next with the previous
                {
                    var currentNumber = numbers[i];
                    if (currentNumber == previous)
                    {
                        count++;
                    }
                    else
                    {
                        Console.WriteLine($"{previous} - {count}");
                        count = 1;
                    }
                    previous = currentNumber;
                }
                //Console.WriteLine($"{previous} - {count}"); - in case we do not add int.Max.Value at the end of the list
            }



            ////Using an array for sorting and counting the numbers:

            //List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            //int[] counts = new int[nums.Max() + 1]; //an array containing all values from the list (in cells from 0 to Max + 1)
            ////int[] sortedElements = new int[1001]; //an array containing all possible values from the allowed inteval

            //foreach (var num in nums)
            //{
            //    counts[num]++; //increasing the value at this cell of the array with 1 at each occurence in the list
            //}

            //for (int i = 0; i < counts.Length; i++)
            //{
            //    if (counts[i] > 0) //skips the cells that did not occur at at all - their value is still 0
            //    {
            //        Console.WriteLine($"{i} -> {counts[i]}"); //prints: the number -> the number of occurences
            //    }
            //}
        }
    }
}
