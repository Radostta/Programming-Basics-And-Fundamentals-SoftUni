using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
               .Split()
               .Select(int.Parse)
               .ToList();

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
                    Console.Write($"{number} ");
                }
                Console.WriteLine();
            }

            //List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            //List<int> currentSeq = new List<int>();
            //List<int> maxSeq = new List<int>();

            //int currentCount = 0;
            //int maxCount = 0;

            //for (int i = nums.Count - 1; i >= 1; i--)
            //{
            //    if (nums[i] == nums[i - 1])
            //    {
            //        currentSeq.Add(nums[i]);
            //        if (currentCount == 0)
            //        {
            //            currentSeq.Add(nums[i - 1]);
            //        }
            //        currentCount++;
            //    }
            //    else
            //    {
            //        currentCount = 0;
            //        currentSeq = new List<int>();
            //    }

            //    if (maxCount <= currentCount)
            //    {
            //        maxCount = currentCount;
            //        maxSeq = currentSeq;
            //    }
            //}

            //Console.WriteLine(string.Join(" ", maxSeq));
        }
    }
}
