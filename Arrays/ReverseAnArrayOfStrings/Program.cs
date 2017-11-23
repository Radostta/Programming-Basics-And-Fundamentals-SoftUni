using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseAnArrayOfStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] items = input.Split(' ');

            var reversed = items.Reverse();

            Console.WriteLine(String.Join(" ", reversed));

            ////Third solution:

            //var nums = Console.ReadLine().Split(' ').ToArray();

            //for (int i = 0; i < nums.Length / 2; i++)
            //{
            //    SwapElements(nums, i, nums.Length - 1 - i);
                  ////METHOD:
            //    //static void SwapElements(string[] arr, int i, int j)
            //    //{
            //      // var oldElement = arr[i];
            //      //arr[i] = arr[j];
            //      //arr[j] = oldElement;
            //    //}
            //}
            
            ////Second solution:

            //Console.WriteLine(String.Join(" ", Console.ReadLine().Split(' ').Reverse()));
            
            ////First solution:

            //string input = Console.ReadLine();
            //string[] items = input.Split(' ');

            //string[] reversed = new string[items.Length];

            //for (int i = 0; i < items.Length; i++)
            //{
            //    reversed[items.Length - 1 - i] = items[i];
            //}

            //Console.WriteLine(String.Join(" ", reversed));


        }
    }
}
