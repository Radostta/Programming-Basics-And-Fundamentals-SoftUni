using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassionDays
{
    class Program
    {
        static void Main(string[] args)
        {
            //decimal money = decimal.Parse(Console.ReadLine());
            //string command = Console.ReadLine();
            //int purchases = 0;

            //while (command != "mall.Enter")
            //{
            //    command = Console.ReadLine();
            //}

            //command = Console.ReadLine();

            //while (command != "mall.Exit")
            //{
            //    string actions = command;
            //    for (int i = 0; i < actions.Length; i++)
            //    {
            //        decimal price = 0;
            //        if (actions[i] >= 65 && actions[i] <= 90)
            //        {
            //            price = actions[i] * 0.5m;
            //            if (money < price)
            //            {
            //                continue;
            //            }

            //            money -= price;
            //            purchases++;
            //        }
            //        else if (actions[i] >= 97 && actions[i] <= 122)
            //        {
            //            price = actions[i] * 0.3m;
            //            if (money < price)
            //            {
            //                continue;
            //            }

            //            money -= price;
            //            purchases++;
            //        }
            //        else if (actions[i] == '%')
            //        {
            //            if (money > 0)
            //            {
            //                money /= 2;
            //                purchases++;
            //            }
            //        }
            //        else if (actions[i] == '*')
            //        {
            //            money += 10;
            //        }
            //        else
            //        {
            //            price = actions[i];
            //            if (money < price)
            //            {
            //                continue;
            //            }

            //            money -= price;
            //            purchases++;
            //        }
            //    }

            //    command = Console.ReadLine();
            //}


            //if (purchases == 0)
            //{
            //    Console.WriteLine("No purchases. Money left: {0:f2} lv.", money);
            //}
            //else
            //{
            //    Console.WriteLine("{0} purchases. Money left: {1:f2} lv.", purchases, money);
            //}



            //MY SOLUTION: It has to be DECIMAL, instead of double

            decimal money = decimal.Parse(Console.ReadLine());
            string input = Console.ReadLine();

            int purchasesCount = 0;
            decimal price = 0;

            //Following not needed => there is no input before <mall.Enter> in the tests:
            //while (input != "mall.Enter")
            //{
            //    input = Console.ReadLine(); // or continue;
            //}

            input = Console.ReadLine();

            while (input != "mall.Exit")
            {
              for (int i = 0; i < input.Length; i++)
                {
                    if (input[i] >= 65 && input[i] <= 90)
                    {
                        price = input[i] * 0.5m;

                        if (money >= price)
                        {
                            money -= price;
                            purchasesCount++;
                        }
                        //if (money < price) continue;
                        //money -= price;
                        //purchasesCount++;
                    }
                    else if (input[i] >= 97 && input[i] <= 122)
                    {
                        price = input[i] * 0.3m;
                        if (money >= price)
                        {
                            money -= price;
                            purchasesCount++;
                        }
                        //if (money < price) continue;
                        //money -= price;
                        //purchasesCount++;
                    }
                    else if (input[i] == 37)
                    {
                        if (money > 0)
                        {
                            money /= 2;
                            purchasesCount++;
                        }
                    }
                    else if (input[i] == 42)
                    {
                        money += 10;
                    }
                    else
                    {
                        price = input[i];
                        if (money >= price)
                        {
                            money -= price;
                            purchasesCount++;
                        }
                        //if (money < price) continue;
                        //money -= price;
                        //purchasesCount++;
                    }
                }
                input = Console.ReadLine();
            }

            if (purchasesCount == 0)
            {
                Console.WriteLine($"No purchases. Money left: {money:f2} lv.");
            }
            else
            {
                Console.WriteLine($"{purchasesCount} purchases. Money left: {money:f2} lv.");
            }

            //NOTE:
            //string sample = "text";
            //int eNumValue = sample[1];
            //Console.WriteLine(sample[1]); // e
            //Console.WriteLine(eNumValue); // 101
        }
    }
}

