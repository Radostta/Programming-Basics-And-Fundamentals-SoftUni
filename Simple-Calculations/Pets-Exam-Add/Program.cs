using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pets_Exam_Add
{
    class Program
    {
        static void Main(string[] args)
        {
            var days = int.Parse(Console.ReadLine());
            var food = double.Parse(Console.ReadLine());
            var dogServing = double.Parse(Console.ReadLine());
            var catServing = double.Parse(Console.ReadLine());
            var turtleInGrams = double.Parse(Console.ReadLine());

            var turtleServing = turtleInGrams / 1000;

            var foodEaten = (dogServing + catServing + turtleServing) * days;

            if (foodEaten <= food)
            {
                Console.WriteLine($"{Math.Floor(food - foodEaten)} kilos of food left.");
            }
            else
            {
                Console.WriteLine($"{Math.Ceiling(foodEaten - food)} more kilos of food are needed.");
            }
        }
    }
}
