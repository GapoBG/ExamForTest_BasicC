using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harvest
{
    class harvest
    {
        static void Main(string[] args)
        {
            var X = int.Parse(Console.ReadLine());
            var Y = double.Parse(Console.ReadLine());
            var needL = int.Parse(Console.ReadLine());
            var workers = int.Parse(Console.ReadLine());

            var Harvest = X * Y;
            var wine = 0.4 * Harvest / 2.5;

            if (wine >= needL)
            {
                var delta = Math.Ceiling(wine - needL);
                var needPerson = Math.Ceiling(delta / workers);
                Console.WriteLine("Good harvest this year! Total wine: {0} liters.", wine);
                Console.WriteLine("{0} liters left -> {1:0} liters per person.", delta, needPerson);
            }
            else
            {
                var delta = Math.Floor(needL - wine);
                Console.WriteLine("It will be a tough winter! More {0} liters wine needed.", delta);
            }

        }
    }
}
