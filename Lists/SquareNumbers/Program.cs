﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputLine = Console.ReadLine();
            List<string> items = inputLine.Split(' ').ToList();

            List<int> squares = new List<int>();

            foreach (var item in items)
            {
                int number = int.Parse(item);

                double root = Math.Sqrt(number);
                double rootAsInt = (int)root;

                if (root == rootAsInt)
                {
                    squares.Add(number);
                }
            }

            //Print in discending order:

            //Using lambda function instead of.sort and .reverse:
            squares.Sort((a, b) => b.CompareTo(a));

            //squares.Sort();
            //squares.Reverse();

            Console.WriteLine(string.Join(" ", squares));
           
            ////Using for cycle instead of .Reverse:
            //for (int i = squares.Count - 1; i >= 0; i--)
            //{
            //    Console.WriteLine(squares[i] + " ");
            //}

        }
    }
}
