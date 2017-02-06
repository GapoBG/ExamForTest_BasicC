using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flowers
{
    class Flowers
    {
        static void Main(string[] args)
        {
            var brHrizantemi = int.Parse(Console.ReadLine());
            var brRozi = int.Parse(Console.ReadLine());
            var brLaleta = int.Parse(Console.ReadLine());
            var season = Console.ReadLine().ToLower();
            var weekend = Console.ReadLine().ToLower();
            var brFlolers = brHrizantemi + brLaleta + brRozi;

            var priceHrizantemi = 0.0;
            var priceRozi = 0.0;
            var priceLaleta = 0.0;

            if (season == "spring" || season == "summer")
            {
                priceHrizantemi = brHrizantemi * 2.00;
                priceRozi = brRozi * 4.10;
                priceLaleta = brLaleta * 2.50;
            }

            else if (season == "autumn" || season == "winter")
            {
                priceHrizantemi = brHrizantemi * 3.75;
                priceRozi = brRozi * 4.50;
                priceLaleta = brLaleta * 4.15;
            }

            var priceAll = priceHrizantemi + priceLaleta + priceRozi;

            if (weekend == "y")
            {
                priceAll  *= 1.15;
            }

            if (season == "spring" && brLaleta > 7)
            {
                priceAll *= 0.95;
            }
            if (season == "winter" && brRozi >= 10)
            {
                priceAll *= 0.9;
            }
            if (brFlolers >= 20)
            {
                priceAll *= 0.80;
            }

            Console.WriteLine("{0:f2}", priceAll + 2);
        }
    }
}
