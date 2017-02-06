using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartLilly
{
    class smartLilly
    {
        static void Main(string[] args)
        {
            var age = int.Parse(Console.ReadLine());
            var priceWash = double.Parse(Console.ReadLine());
            var priceToys = double.Parse(Console.ReadLine());
            var oddAge = 0;
            var evenAge = 0;
            var money = 0;
            var sumMoney = 0;
            var allMoney = 0.00;
            

            if (age % 2 == 0)
            {
                oddAge = evenAge = age / 2;
            }
            else
            {
                evenAge = age / 2;
                oddAge = evenAge + 1;
            }

            for (var i = 0; i <= evenAge; i++)
            {
                sumMoney = sumMoney + money;
                money+=10; 
            }
            allMoney = (sumMoney + (oddAge * priceToys)) - (evenAge * 1);

            if (allMoney >= priceWash)
            {
                var delta = allMoney - priceWash;
                Console.WriteLine("Yes! {0:f2}", delta);
            }
            else
            {
                var delta = priceWash - allMoney;
                Console.WriteLine("No! {0:f2}", delta);
            }
        }
    }
}
