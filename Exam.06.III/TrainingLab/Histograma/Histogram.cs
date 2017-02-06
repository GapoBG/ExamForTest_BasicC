using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Histograma
{
    class Histogram
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            double p1 = 0;
            double p2 = 0;
            double p3 = 0;
            double p4 = 0;
            double p5 = 0;

            for (int i = 1 ; i <= n; i++)
            {
               var num = int.Parse(Console.ReadLine());

               if (num >= 1 && num < 200)
               {
                   p1++;
               }
               else if (num >= 200 && num <= 399)
               {
                   p2++;
               }
               else if (num >= 400 && num <= 599)
               {
                   p3++;
               }
               else if (num >= 600 && num <= 799)
               {
                   p4++;
               }
               else if (num >= 800 && num <= 1000)
               {
                   p5++;
               }

       
            }
            double result1 = (p1 / n) * 100;
            double result2 = (p2 / n) * 100;
            double result3 = (p3 / n) * 100;
            double result4 = (p4 / n) * 100;
            double result5 = (p5 / n) * 100;

            Console.WriteLine("{0:f2}%", result1);
            Console.WriteLine("{0:f2}%", result2);
            Console.WriteLine("{0:f2}%", result3);
            Console.WriteLine("{0:f2}%", result4);
            Console.WriteLine("{0:f2}%", result5);

        }
    }
}
