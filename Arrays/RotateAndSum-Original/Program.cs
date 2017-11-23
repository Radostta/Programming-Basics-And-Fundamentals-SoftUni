using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotateAndSum_Original
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var rotationTimes = int.Parse(Console.ReadLine()); // last position of i: (i + r) % n;      

            int[] sum = new int[numbers.Length]; //sum of indexes of first and second rotation arrays

            for (int r = 0; r < rotationTimes; r++)
            {
                RotateArray(numbers); //rotating the array up to number of rotation times

                for (int i = 0; i < sum.Length; i++)
                {
                    sum[i] = sum[i] + numbers[i]; //adding the indexes of each rotation
                }
            }

            Console.WriteLine(String.Join(" ", sum));            
        }

        static void RotateArray(int[] numbers)
        {
            var lastNumber = numbers.Last(); //returns the last element of the array

            for (int i = numbers.Length - 1; i > 0; i--) //indexes move to the left 
            {
                numbers[i] = numbers[i - 1];
            }
            numbers[0] = lastNumber; //the last element becomes first
        }
    }
}
