using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            double widthCake = double.Parse(Console.ReadLine());
            double lengthCake = double.Parse(Console.ReadLine());
            double cakeArea = widthCake * lengthCake;
            double cakePieces = cakeArea / 1;
            //bool isFinished = false;

            while (true)
            {
                string action = Console.ReadLine();
                if (action == "STOP") break;
                cakePieces -= int.Parse(action);
                if (cakePieces < 0)
                {
                    //isFinished = true;
                    break;
                }
            }

            if (cakePieces < 0) Console.WriteLine($"No more cake left! You need {Math.Abs(cakePieces)} pieces more."); //(isFinished == true) 
            else Console.WriteLine($"{cakePieces} pieces are left.");


            //    Console.WriteLine($"{cakePieces} pieces are left.");

            //    Console.WriteLine($"No more cake left! You need {Math.Abs(cakePieces)} pieces more.");           

        }
    }
}
