using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SieveOfEratosthenes_Original
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool[] primes = new bool[n + 1]; // has to contain all numbers from 1 to n

            for (int i = 0; i < primes.Length; i++)
            {
                primes[i] = true;
            }

            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (primes[i])
                {
                    for (int j = i * i; j <primes.Length; j += i)
                    {
                        primes[j] = false;
                    }
                }
            }

            //List<int> result = new List<int>(); //Printing with list step 1

            for (int i = 2; i < primes.Length; i++)
            {
                if (primes[i])
                {
                    Console.Write(i + " ");
                    //result.Add(i); //Printing with list step 2
                }
            }

            //Console.WriteLine($"{string.Join(" ", result)}"); //Printing with list step 3
        }
    }
}
