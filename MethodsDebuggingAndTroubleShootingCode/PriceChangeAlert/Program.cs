using System;

class PriceChangeAlert
{
    static void Main()
    {
        int pricesCount = int.Parse(Console.ReadLine());
        double treshold = double.Parse(Console.ReadLine());
        double lastPrice = double.Parse(Console.ReadLine());

        for (int i = 0; i < pricesCount - 1; i++)
        {
            double currentPrice = double.Parse(Console.ReadLine());
            double difference = CalcDifference(lastPrice, currentPrice);

            bool isSignificantDifference = FindDifference(difference, treshold);
            string message = ReturnMessage(currentPrice, lastPrice, difference, isSignificantDifference);

            Console.WriteLine(message);

            lastPrice = currentPrice;
        }
    }

    static string ReturnMessage(double currentPrice, double lastPrice, double difference, bool FindDifference)
    {
        string message = "";
        if (difference == 0)
        {
            message = string.Format("NO CHANGE: {0}", currentPrice);
        }
        else if (!FindDifference)
        {
            message = string.Format("MINOR CHANGE: {0} to {1} ({2:F2}%)", lastPrice, currentPrice, difference * 100);
        }
        else if (FindDifference && (difference > 0))
        {
            message = string.Format("PRICE UP: {0} to {1} ({2:F2}%)", lastPrice, currentPrice, difference * 100);
        }
        else if (FindDifference && (difference < 0))
            message = string.Format("PRICE DOWN: {0} to {1} ({2:F2}%)", lastPrice, currentPrice, difference * 100);
        return message;
    }

    static bool FindDifference(double treshold, double difference)
    {
        if (Math.Abs(treshold) >= difference)
        {
            return true;
        }
        return false;
    }

    static double CalcDifference(double lastPrice, double currentPrice)
    {
        double result = (currentPrice - lastPrice) / lastPrice;
        return result;
    }
}
