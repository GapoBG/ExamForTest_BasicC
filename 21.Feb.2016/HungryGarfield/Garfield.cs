using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HungryGarfield
{
    class Garfield
    {
        static void Main(string[] args)
        {
            var money = decimal.Parse(Console.ReadLine());
            var rate = decimal.Parse(Console.ReadLine());
            var pizzaPrice = decimal.Parse(Console.ReadLine());
            var lasagnaPrice = decimal.Parse(Console.ReadLine());
            var sandwichPrice = decimal.Parse(Console.ReadLine());
            var pizzaQuantity = uint.Parse(Console.ReadLine());
            var lasagnaQuantity = uint.Parse(Console.ReadLine());
            var sandwichQuantity = uint.Parse(Console.ReadLine());
            decimal delta = 0;

            decimal result = ((pizzaPrice / rate) * pizzaQuantity + (lasagnaPrice / rate) * lasagnaQuantity + (sandwichPrice / rate) * sandwichQuantity);

            if (result <= money)
            {
                delta = money - result;
                Console.WriteLine("Garfield is well fed, John is awesome. Money left: ${0:f2}.", delta);
            }
            else
            {
                delta = result - money;
                Console.WriteLine("Garfield is hungry. John is a badass. Money needed: ${0:f2}.", delta);
            }
        }
    }
}
