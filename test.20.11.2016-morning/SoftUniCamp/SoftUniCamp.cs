using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniCamp
{
    class SoftUniCamp
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            double sum1 = 0;
            double sum2 = 0;
            double sum3 = 0;
            double sum4 = 0;
            double sum5 = 0;
            double sumall = 0;

            double result1 = 0.0;
            double result2 = 0.0;
            double result3 = 0.0;
            double result4 = 0.0;
            double result5 = 0.0;

            for (int i = 1; i <= n; i++)
            { 
                var num = int.Parse(Console.ReadLine());

                if (num > 0 && num <= 5)
                {
                    sum1 = sum1 + num; 
                }
                else if (num > 5 && num <= 12)
                {
                    sum2 = sum2 + num; 
                }
                else if (num > 12 && num <= 25)
                {
                    sum3 = sum3 + num;
                }
                else if (num > 25 && num <= 40)
                {
                    sum4 = sum4 + num;
                }
                else if (num > 40)
                {
                    sum5 = sum5 + num;
                }
                sumall = sumall + num;             
            }
            result1 = (sum1 / sumall) * 100;
            result2 = (sum2 / sumall) * 100;
            result3 = (sum3 / sumall) * 100;
            result4 = (sum4 / sumall) * 100;
            result5 = (sum5 / sumall) * 100;

            Console.WriteLine("{0:f2}%", result1);
            Console.WriteLine("{0:f2}%", result2);
            Console.WriteLine("{0:f2}%", result3);
            Console.WriteLine("{0:f2}%", result4);
            Console.WriteLine("{0:f2}%", result5);
        }
    }
}
