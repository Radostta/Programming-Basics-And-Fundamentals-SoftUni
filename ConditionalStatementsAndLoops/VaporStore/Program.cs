using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VaporStore
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double moneySpent = 0;
            string command = Console.ReadLine();        

            while (budget > 0)
            {
                if (command == "Game Time")
                {
                    Console.WriteLine($"Total spent: ${moneySpent:f2}. Remaining: ${budget:f2}");
                    break;
                }
                else if (command == "OutFall 4")
                {
                    if (budget >= 39.99)
                    {
                        Console.WriteLine("Bought OutFall 4");
                        budget -= 39.99;
                        moneySpent += 39.99;
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }
                else if (command == "CS: OG")
                {
                    if (budget >= 15.99)
                    {
                        Console.WriteLine("Bought CS: OG");
                        budget -= 15.99;
                        moneySpent += 15.99;
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }
                else if (command == "Zplinter Zell")
                {
                    if (budget >= 19.99)
                    {
                        Console.WriteLine("Bought Zplinter Zell");
                        budget -= 19.99;
                        moneySpent += 19.99;
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }
                else if (command == "Honored 2")
                {
                    if (budget >= 59.99)
                    {
                        Console.WriteLine("Bought Honored 2");
                        budget -= 59.99;
                        moneySpent += 59.99;
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }
                else if (command == "RoverWatch")
                {
                    if (budget >= 29.99)
                    {
                        Console.WriteLine("Bought RoverWatch");
                        budget -= 29.99;
                        moneySpent += 29.99;
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }
                else if (command == "RoverWatch Origins Edition")
                {
                    if (budget >= 39.99)
                    {
                        Console.WriteLine("Bought RoverWatch Origins Edition");
                        budget -= 39.99;
                        moneySpent += 39.99;
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }
                else
                {
                    Console.WriteLine("Not Found");
                }

                command = Console.ReadLine();
            }

            if (budget <= 0)
            {
                Console.WriteLine("Out of money!");
            }
        }
    }
}
