using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string category = Console.ReadLine();
            int peopleCount = int.Parse(Console.ReadLine());

            double transport = 0;
            double cost = 0;          

            if (peopleCount < 5)
            {
                transport = budget * 0.75;
            }
            else if (peopleCount < 10)
            {
                transport = budget * 0.60;
            }
            else if (peopleCount < 25)
            {
                transport = budget * 0.50;
            }
            else if (peopleCount < 50)
            {
                transport = budget * 0.40;
            }
            else if (peopleCount >= 50)
            {
                transport = budget * 0.25;
            }

            budget -= transport;


            if (category == "VIP")
            {
                cost = peopleCount * 499.99;              
            }
            else if (category == "Normal")
            {
                cost = peopleCount * 249.99;               
            }

            double difference = Math.Abs(budget - cost);

            if (cost <= budget)
            {
                Console.WriteLine($"Yes! You have {difference:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {difference:f2} leva.");
            }
        }
    }
}
