using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Profit
{
    class profit
    {
        static void Main(string[] args)
        {
            var workDay = int.Parse(Console.ReadLine());
            var moneyOnDays = double.Parse(Console.ReadLine());
            var fixUSD = double.Parse(Console.ReadLine());

            var MonthMoney = workDay * moneyOnDays;
            var YearsMoney = (MonthMoney * 12) + (MonthMoney * 2.5);
            var Tax = YearsMoney * 0.25;
            var TotalMoney = (YearsMoney - Tax) * fixUSD;
            var AvrMoneyDay = TotalMoney / 365;

            Console.WriteLine(Math.Round(AvrMoneyDay,2));

        }
    }
}
