using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //the shortest way:
            List<double> numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            numbers.Sort();
            Console.WriteLine(string.Join(" <= ", numbers));

            //the short way:
            //string inputLine = Console.ReadLine();

            //List<string> items = inputLine.Split(' ').ToList();
            //List<decimal> numbers = new List<decimal>();

            //foreach (var item in items)
            //{
            //    numbers.Add(decimal.Parse(item));
            //}

            //numbers.Sort();

            //string joined = String.Join(" <= ", numbers);
            //Console.WriteLine(joined);


            //the long way:
            //for (int i = 0; i < numbers.Count; i++)
            //{
            //    Console.Write(numbers[i]);
            //    bool isLast = i == numbers.Count - 1;
            //    if (!isLast)
            //    {
            //        Console.Write(" <= ");
            //    }               


                //the longer way:
                //bool isLast = i == numbers.Count - 1;
                //if (isLast)
                //{
                //    Console.Write(numbers[i]);
                //}
                //else
                //{
                //    Console.Write(numbers[i] + " <= ");
                //}
            //}
            //Console.WriteLine();


            //Sorting as strings: - sorts them lexicographically
            //string inputLine = Console.ReadLine();

            //List<string> items = inputLine.Split(' ').ToList();

            //items.Sort();

            //for (decimal i = 0; i < items.Count; i++)
            //{
            //    Console.Write(items[i]);
            //}

        }
    }
}
