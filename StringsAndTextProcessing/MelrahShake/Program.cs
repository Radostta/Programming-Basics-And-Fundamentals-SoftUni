﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelrahShake
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var key = Console.ReadLine();

            while (true)
            {
                var leftIndex = input.IndexOf(key);
                var rightIndex = input.LastIndexOf(key);

                var leftIndexExists = leftIndex != -1;
                var rightIndexExists = rightIndex != -1;

                var leftIndexAndRightIndexAreEqual = leftIndex == rightIndex;

                var keyIsEmpty = key == string.Empty; //key.Length <= 0;

                if (leftIndexExists && rightIndexExists && !leftIndexAndRightIndexAreEqual && !keyIsEmpty)
                {
                    input = input.Remove(rightIndex, key.Length);
                    input = input.Remove(leftIndex, key.Length);

                    Console.WriteLine("Shaked it.");
                    key = key.Remove(key.Length / 2, 1);
                }
                else
                {
                    Console.WriteLine("No shake.");
                    Console.WriteLine(input);
                    break;
                }
            }



        }
    }
}
