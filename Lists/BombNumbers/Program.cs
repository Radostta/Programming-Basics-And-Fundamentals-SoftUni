using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            var numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            var specialNumber = numbers[0];
            var power = numbers[1];

            for (int i = 0; i < input.Count; i++)
            {
                if (input[i] == specialNumber)
                {
                    int left = Math.Max(i - power, 0);
                    int right = Math.Min(i + power, input.Count - 1);
                    int lenght = right - left + 1;
                    input.RemoveRange(left, lenght);
                    i = 0;
                }
            }
            Console.WriteLine(string.Join(" ", input.Sum()));
        }
    }
}
