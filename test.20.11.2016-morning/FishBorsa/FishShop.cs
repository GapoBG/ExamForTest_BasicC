using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishBorsa
{
    class FishShop
    {
        static void Main(string[] args)
        {
            var priceSKUMRIQ = double.Parse(Console.ReadLine());
            var priceCACA = double.Parse(Console.ReadLine());
            var kgPALAMUD = double.Parse(Console.ReadLine());
            var kgSAFRID = double.Parse(Console.ReadLine());
            var kgMIDI = int.Parse(Console.ReadLine());

            var pricePalamud = priceSKUMRIQ + priceSKUMRIQ * 0.60;
            var priceSafrid = priceCACA + priceCACA * 0.8;
            var priceMIDI = 7.50;

            var sumPalamud = kgPALAMUD * pricePalamud;
            var sumSafrid = kgSAFRID * priceSafrid;
            var sumMIDI = kgMIDI * priceMIDI;

            var result = sumPalamud + sumSafrid + sumMIDI;
            Console.WriteLine("{0:f2}",result);

        }
    }
}
