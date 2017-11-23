using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoolPipes
{
    class Program
    {
        static void Main(string[] args)
        {
            double poolVolume = double.Parse(Console.ReadLine()); //inLiters
            double pipe1LitersPerHour = double.Parse(Console.ReadLine()); 
            double pipe2LitersPerHour = double.Parse(Console.ReadLine()); 
            double hours = double.Parse(Console.ReadLine()); 

            double pipe1Debit = pipe1LitersPerHour * hours;
            double pipe2Debit = pipe2LitersPerHour * hours;
            double debit = pipe1Debit + pipe2Debit;
            
            double debitPercent = Math.Truncate(debit / poolVolume * 100);
            double p1 = Math.Truncate(pipe1Debit / debit * 100);
            double p2 = Math.Truncate(pipe2Debit / debit * 100);

            double difference = Math.Abs(poolVolume - debit);

            if (debit > poolVolume)
            {
                Console.WriteLine($"For {hours} hours the pool overflows with {difference:f1} liters.");
            }
            else
            {
                Console.WriteLine($"The pool is {debitPercent}% full. Pipe 1: {p1}%. Pipe 2: {p2}%.");            
            }




        }
    }
}
