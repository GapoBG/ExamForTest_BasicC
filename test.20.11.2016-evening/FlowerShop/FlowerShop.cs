using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerShop
{
    class FlowerShop
    {
        static void Main(string[] args)
        {
            var brMagnoli = int.Parse(Console.ReadLine());
            var brZumbuli = int.Parse(Console.ReadLine());
            var brRozi = int.Parse(Console.ReadLine());
            var brKaktusi = int.Parse(Console.ReadLine());
            var pricePresents = double.Parse(Console.ReadLine());

            var allPrice = brMagnoli * 3.25 + brZumbuli * 4 + brRozi * 3.5 + brKaktusi * 8;
            var tax = allPrice * 0.05;
            var winMoney = allPrice - tax;

            if (pricePresents > winMoney)
            {
                var delta = Math.Ceiling(pricePresents - winMoney);
                Console.WriteLine("She will have to borrow {0} leva.", delta);
            }
            else
            {
                var delta = Math.Floor(winMoney - pricePresents);
                Console.WriteLine("She is left with {0} leva.", delta);
            }
        }
    }
}
