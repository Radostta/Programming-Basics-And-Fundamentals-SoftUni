using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var numbers = input.Split().Select(double.Parse).ToArray();

            var countInAscendingOrder = new SortedDictionary<double, int>();

            foreach (var number in numbers)
            {
                if (countInAscendingOrder.ContainsKey(number))
                {
                    countInAscendingOrder[number]++;
                }
                else
                {
                    countInAscendingOrder[number] = 1;
                }
            }

            //Printing:

            foreach (var item in countInAscendingOrder.Keys)
            {
                Console.WriteLine($"{item} -> {countInAscendingOrder[item]}");
            }
            
            //OR:
            //foreach (var item in countInAscendingOrder)
            //{
            //    Console.WriteLine($"{item.Key} -> {item.Value}");
            //}
        }
    }
}
