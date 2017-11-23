using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoolPipes_Exam_Book
{
    class Program
    {
        static void Main(string[] args)
        {
         int poolVolume = int.Parse(Console.ReadLine());
         int firstPipePerHour = int.Parse(Console.ReadLine());
         int secondPipePerHour = int.Parse(Console.ReadLine());
         double hours = double.Parse(Console.ReadLine());
         
         double firstPipeDebit = firstPipePerHour * hours;
         double secondPipeDebit = secondPipePerHour * hours;
         double sum = firstPipeDebit + secondPipeDebit;
         
         if (sum <= poolVolume)
         {
             double sumPercent = Math.Truncate(sum / poolVolume * 100.0);
             double firstPipePercent = Math.Truncate(firstPipeDebit / sum * 100.0);
             double secondPipePercent = Math.Truncate(secondPipeDebit / sum * 100.0);
         
             Console.WriteLine($"The pool is {sumPercent}% full. Pipe 1: {firstPipePercent}%. Pipe 2: {secondPipePercent}%.");
         }
         else
         {
             Console.WriteLine($"For {hours} hours the pool overflows with {sum - poolVolume} liters.");
         }



            
            
            

        }
    }
}
