using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumStep3
{
    class SumStep3
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var sum1 = 0;
            var sum2 = 0;
            var sum3 = 0;
            var br1 = 1;
            var br2 = 2;
            var br3 = 3;


            for (int i = 1; i <= n; i++)
            {
                var num = int.Parse(Console.ReadLine());

                if (i == br1)
                {
                    sum1 = sum1 + num;
                    br1 += 3;
                }
                else if (i == br2)
                {
                    sum2 = sum2 + num;
                    br2 += 3;
                }
                else if (i == br3)
                {
                    sum3 = sum3 + num;
                    br3 += 3;
                }

            }
            Console.WriteLine("sum1 {0}", sum1);
            Console.WriteLine("sum2 {0}", sum2);
            Console.WriteLine("sum3 {0}", sum3);
        }
    }
}
