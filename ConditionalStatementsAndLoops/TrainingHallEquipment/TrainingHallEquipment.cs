using System;

namespace TrainingHallEquipment
{
    class TrainingHallEquipment
    {
        static void Main()
        {
            double budget = double.Parse(Console.ReadLine());
            int items = int.Parse(Console.ReadLine());
            double subtotal = 0;
            for (int i = 1; i <= items; i++)
            {
                string name = Console.ReadLine();
                double price = double.Parse(Console.ReadLine());
                int count = int.Parse(Console.ReadLine());
                subtotal += price * count;
                if (count == 1)
                {
                    Console.WriteLine($"Adding {count} {name} to cart.");
                }
                else
                {
                    Console.WriteLine($"Adding {count} {name}s to cart.");

                }
            }
            Console.WriteLine($"Subtotal: ${subtotal:f2}");
            if (budget >= subtotal)
            {
                Console.WriteLine($"Money left: ${budget - subtotal:f2}");
            }
            else
                Console.WriteLine($"Not enough. We need ${subtotal - budget:f2} more.");
        }
    }
}