using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseArrayOfIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Third solution:

            var n = int.Parse(Console.ReadLine());
            var numbers = new int[n];
            var reversedNumbers = new int[numbers.Length]; //or [n]

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
                reversedNumbers[numbers.Length -1 -i] = numbers[i]; //it won't work the other way around, 'cause the last number is not yet written
            }

            Console.WriteLine(String.Join(" ", reversedNumbers));

            
            //Second solution:
            //var numberOfElements = int.Parse(Console.ReadLine());
            //var numbers = new int[numberOfElements];

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    numbers[i] = int.Parse(Console.ReadLine());
            //    //var currentNumber = int.Parse(Console.ReadLine());
            //    //numbers[i] = currentNumber;
            //}

            //for (int i = numbers.Length - 1; i >= 0; i--)
            //{
            //    Console.Write(numbers[i] + " ");                
            //}
            
            //My solution:
            //int n = int.Parse(Console.ReadLine());           
            //var reversedIntegers = new int[n];

            //for (int i = n - 1; i >= 0; i--)
            //{
            //    reversedIntegers[i]= int.Parse(Console.ReadLine());
            //}

            //Console.WriteLine(String.Join(" ", reversedIntegers));
            
        }
    }
}
