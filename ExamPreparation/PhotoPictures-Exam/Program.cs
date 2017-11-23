using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoPictures_Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int picturesQuantity = int.Parse(Console.ReadLine());
            string pictureType = Console.ReadLine();
            string orderType = Console.ReadLine();
            double price = 0;

            switch (pictureType)
            {
                case "9X13":
                    price = picturesQuantity * 0.16;
                    if (picturesQuantity >= 50)
                    {
                        price -= price * 0.05;
                    }
                    break;
                case "10X15":
                    price = picturesQuantity * 0.16;
                    if (picturesQuantity >= 80)
                    {
                        price -= price * 0.03;
                    }
                    break;
                case "13X18":
                    price = picturesQuantity * 0.38;                   
                    if (picturesQuantity > 100)
                    {
                        price -= price * 0.05;
                    }
                    else if (picturesQuantity >= 50)
                    {
                        price -= price * 0.03;
                    }
                    break;
                case "20X30":
                    price = picturesQuantity * 2.90;
                    if (picturesQuantity > 50)
                    {
                        price -= price * 0.09;
                    }
                    else if (picturesQuantity >= 10)
                    {
                        price -= price * 0.07;
                    }
                    break;                    
            }

            if (orderType == "online")
            {
                price -= price * 0.02;
            }

            Console.WriteLine($"{price:f2}BGN");
        }
    }
}
