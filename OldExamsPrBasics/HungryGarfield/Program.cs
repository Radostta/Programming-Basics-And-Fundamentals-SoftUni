using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HungryGarfield
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal moneyDollars = decimal.Parse(Console.ReadLine());
            decimal dollarExchangeRate = decimal.Parse(Console.ReadLine());
            decimal pizzaPriceLeva = decimal.Parse(Console.ReadLine());
            decimal lasagnaPriceLeva = decimal.Parse(Console.ReadLine());
            decimal sandwichPriceLeva = decimal.Parse(Console.ReadLine());
            decimal pizzasCount = decimal.Parse(Console.ReadLine());
            decimal lasagnasCount = decimal.Parse(Console.ReadLine());
            decimal sandwichesCount = decimal.Parse(Console.ReadLine());

            decimal pizzasCost = (pizzaPriceLeva / dollarExchangeRate) * pizzasCount;
            decimal lasagnasCost = (lasagnaPriceLeva / dollarExchangeRate) * lasagnasCount;
            decimal sandwichesCost = (sandwichPriceLeva / dollarExchangeRate) * sandwichesCount;

            decimal costDollars = pizzasCost + lasagnasCost + sandwichesCost;
            decimal difference = Math.Abs(moneyDollars - costDollars);

            if (moneyDollars >= costDollars)
            {
                Console.WriteLine($"Garfield is well fed, John is awesome. Money left: ${difference:f2}.");
            }
            else
            {
                Console.WriteLine($"Garfield is hungry. John is a badass. Money needed: ${difference:f2}.");
            }




        }
    }
}
