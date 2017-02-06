using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripStudent
{
    class trip
    {
        static void Main(string[] args)
        {
    
            var moneyAfterPercent = 0.00;
            var money = double.Parse(Console.ReadLine());
            string time = Console.ReadLine().ToLower();

            if (time == "summer")

            {
                if (money <= 100)
                {
                    Console.WriteLine("Somewhere in Bulgaria");
                    moneyAfterPercent = money * 0.3;
                    Console.WriteLine("Camp - {0:f2}", moneyAfterPercent);
                }

                else if (money > 100 && money <= 1000)
                {
                    Console.WriteLine("Somewhere in Balkans");
                    moneyAfterPercent = money * 0.4;
                    Console.WriteLine("Camp - {0:f2}", moneyAfterPercent);
                }

                else if (money > 1000)
                {
                    Console.WriteLine("Somewhere in Europe");
                    moneyAfterPercent = money * 0.9;
                    Console.WriteLine("Hotel - {0:f2}", moneyAfterPercent);
                }
            }

            else if (time == "winter")
            {
                if (money <= 100)
                {
                    Console.WriteLine("Somewhere in Bulgaria");
                    moneyAfterPercent = money * 0.7;
                    Console.WriteLine("Hotel - {0:f2}", moneyAfterPercent);
                }
                else if (money > 100 && money <= 1000)
                {
                    Console.WriteLine("Somewhere in Balkans");
                    moneyAfterPercent = money * 0.8;
                    Console.WriteLine("Hotel - {0:f2}", moneyAfterPercent);
                }
                else if (money > 1000)
                {
                    Console.WriteLine("Somewhere in Europe");
                    moneyAfterPercent = money * 0.9;
                    Console.WriteLine("Hotel - {0:f2}", moneyAfterPercent);
                }
            }
        }
    }
}
