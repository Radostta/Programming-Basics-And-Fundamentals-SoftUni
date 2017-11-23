using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondenseArrayToNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var integers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            while (integers.Length > 1)
            {
                int[] condensedIntegers = new int[integers.Length - 1];

                for (int i = 0; i < condensedIntegers.Length; i++)
                {
                    condensedIntegers[i] = integers[i] + integers[i + 1];                    
                }

                integers = condensedIntegers;
            }

            Console.WriteLine(string.Join(" ", integers));
        }
    }
}
