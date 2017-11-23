using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchTickets_Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            var budget = decimal.Parse(Console.ReadLine());
            var category = Console.ReadLine();
            var numberPeople = int.Parse(Console.ReadLine());

            var transportCost = 0.00m;
            var ticketCost = 0.00m;


            if (numberPeople >= 1 && numberPeople <= 4)
            {
                transportCost = budget * 0.75m;
            }
            else if (numberPeople >= 5 && numberPeople <= 9)
            {
                transportCost = budget * 0.60m;
            }
            else if (numberPeople >= 10 && numberPeople <= 24)
            {
                transportCost = budget * 0.50m;
            }
            else if (numberPeople >= 25 && numberPeople <= 49)
            {
                transportCost = budget * 0.40m;
            }
            else if (numberPeople >= 50)
            {
                transportCost = budget * 0.25m;
            }

            var ticketBudget = budget - transportCost;


            if (category == "VIP")
            {
                ticketCost = numberPeople * 499.99m;
            }
            else if (category == "Normal")
            {
                ticketCost = numberPeople * 249.99m;
            }

            if (ticketBudget >= ticketCost)
            {
                Console.WriteLine("Yes! You have {0:f2} leva left.", ticketBudget - ticketCost);
            }
            else
            {
                Console.WriteLine("Not enough money! You need {0:f2} leva.", ticketCost - ticketBudget);
            }
        }
    }
}
