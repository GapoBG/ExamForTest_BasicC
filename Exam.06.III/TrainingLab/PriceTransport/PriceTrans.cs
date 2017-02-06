using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriceTransport
{
    class PriceTrans
    {
        static void Main(string[] args)
        {

            var km = 0;
            var result = 0.0;

            while ( km < 1 || km > 5000)
            {
                Console.Write("[1...500] Enter km= ");
                km = int.Parse(Console.ReadLine());
            }

            Console.Write("day/night :");
            var period = Console.ReadLine().ToLower();

            if (km < 20)
            {
                if (period == "day")
                {
                    result = 0.7 + (km * 0.79);
                    Console.WriteLine("TAXI-day = {0}", result);
                }
                else
                {
                    result = 0.7 + (km * 0.90);
                    Console.WriteLine("TAXI-night = {0}", result);
                }
            
            }
            else if (km >= 20 && km < 100)
            {
                result = (km * 0.09);
                Console.WriteLine("BUS = {0}", result);
            }

            else
            {
                result = (km * 0.06);
                Console.WriteLine("TRAIN = {0}", result);
            }
        }
    }
}
