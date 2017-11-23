using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            var strings = Console.ReadLine().Split();

            var firstString = strings[0];
            var secondString = strings[1];

            var sum = 0;

            var shorterLenght = Math.Min(firstString.Length, secondString.Length);

            for (int i = 0; i < shorterLenght; i++)
            {
                var firstLetter = (int)firstString[i];
                var secondLetter = (int)secondString[i];

                sum += firstLetter * secondLetter; 
            }

            var longerString = firstString.Length > secondString.Length ? firstString : secondString;

            for (int i = shorterLenght; i < longerString.Length; i++)
            {
                sum += longerString[i];
            }

            Console.WriteLine(sum);
        }
    }
}
