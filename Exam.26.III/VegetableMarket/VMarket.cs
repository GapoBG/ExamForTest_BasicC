using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VegetableMarket
{
    class VMarket
    {
        static void Main(string[] args)
        {




            var euro = 1.94;
            var resultVeg = 0.00;
            var resultFrui = 0.00;
            var result = 0.00;
            var priceVeg = double.Parse(Console.ReadLine());
            var priceFruit = double.Parse(Console.ReadLine());
            var kgVeg = int.Parse(Console.ReadLine());
            var kgFruit = int.Parse(Console.ReadLine());

            resultVeg = (priceVeg * kgVeg) / euro ;
            resultFrui = (priceFruit * kgFruit) / euro;
            result = resultVeg + resultFrui;
            Console.WriteLine(result);


            



        }
    }
}
