using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripleSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int sumC = 0;
            bool isSumFound = false;

            for (int a = 0; a < numbers.Length; a++)
            {
                for (int b = a + 1; b <= numbers.Length - 1; b++)
                {                    
                    sumC = numbers[a] + numbers[b];

                    if (numbers.Contains(sumC))
                    {
                        isSumFound = true;
                        Console.WriteLine($"{numbers[a]} + {numbers[b]} == {sumC}");
                    }                    
                }                
            }

            if (isSumFound == false)
            {
                Console.WriteLine("No");                
            }

            
        }
    }
}
