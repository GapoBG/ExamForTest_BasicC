using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logistics
{
    class Logistics
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            var sum1 = 0.0;
            var sum2 = 0.0;
            var sum3 = 0.0;
            var sumAll = 0.0;
            
            for (int i = 1; i <= num; i++)
            {
                var ton = int.Parse(Console.ReadLine());

                if ( ton > 0 && ton <= 3)
                {
                    sum1 += ton;
                }
                else if (ton >= 4 && ton <= 11)
                {
                    sum2 += ton;
;
                }
                else if (ton >= 12)
                {
                    sum3 += ton;
                }
                sumAll += ton;
            }

            double avarage = ((sum1 * 200) + (sum2 * 175) + (sum3 * 120)) / sumAll;
            var result1 = (sum1 / sumAll) * 100;
            var result2 = (sum2 / sumAll) * 100;
            var result3 = (sum3 / sumAll) * 100;

            Console.WriteLine("{0:f2}", avarage);
            Console.WriteLine("{0:f2}%", result1);
            Console.WriteLine("{0:f2}%", result2);
            Console.WriteLine("{0:f2}%", result3);
        }
    }
}
