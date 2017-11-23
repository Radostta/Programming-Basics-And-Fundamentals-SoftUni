using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintNumbersOnTheConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //input: 1 2 3 4 - with space at the end
            var numbers = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToArray();

            for (int i = 0; i < numbers.Length; i++)
            {
                //Console.WriteLine($"numbers[{i}] = {numbers[i]}");
                Console.WriteLine($"{nameof(numbers)}[{i}] = {numbers[i]}"); //will have no problem, if we change the name of the array in the future
            }

        }
    }
}
