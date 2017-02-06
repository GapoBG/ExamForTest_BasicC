using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeTitles
{
    class ChangeTitles
    {
        static void Main(string[] args)
        {
            var money = double.Parse(Console.ReadLine());
            var weightFloore = double.Parse(Console.ReadLine());
            var hightFloor = double.Parse(Console.ReadLine());
            var sideA = double.Parse(Console.ReadLine());
            var sideH = double.Parse(Console.ReadLine());
            var priceTitles = double.Parse(Console.ReadLine());
            var moneyWorker = double.Parse(Console.ReadLine());

            var areaFlore = weightFloore * hightFloor;
            var areaTitles = (sideA * sideH) / 2;
            var needTitels = Math.Ceiling(areaFlore / areaTitles) + 5;
            var result = needTitels * priceTitles + moneyWorker;

            if (result <= money)
            {
                var delta = money - result;
                Console.WriteLine("{0:f2} lv left.", delta);
            }
            else
            {
                var delta = result - money;
                Console.WriteLine("You'll need {0:f2} lv more.", delta);
            }
        }
    }
}
