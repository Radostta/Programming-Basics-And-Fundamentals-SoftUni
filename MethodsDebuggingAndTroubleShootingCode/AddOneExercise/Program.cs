using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddOneExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var result = AddOne(n);
            Console.WriteLine(result);            
        }

        static int AddOne(int n)
        {
            return n + 1;
        }        
    }
}
