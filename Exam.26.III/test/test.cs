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
            var money = 1.00;
            var moneyAfterPercent = 0.00;

            while (money < 10 || money > 5000)
            {
                Console.Write("Enter, Money [10.00 ... 5000.00]:  ");
                money = double.Parse(Console.ReadLine());
            }
            Console.Write("Enter, Season [summer or winter]: ");
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
                    Console.WriteLine("Somewhere in Europa");
                    moneyAfterPercent = (money * 90) / 100;
                    Console.WriteLine("Camp - {0:f2}", moneyAfterPercent);
                }
            }
            if (time == "winter")
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
                    moneyAfterPercent = money * 0.4;
                    Console.WriteLine("Camp - {0:f2}", moneyAfterPercent);
                }
                else if (money > 1000)
                {
                    Console.WriteLine("Somewhere in Europa");
                    moneyAfterPercent = (money * 90) / 100;
                    Console.WriteLine("Hotel - {0:f2}", moneyAfterPercent);
                }
            }
        }
    }
}
