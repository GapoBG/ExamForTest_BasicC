using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devision
{
    class devision
    {
        static void Main(string[] args)
        {
            var n = float.Parse(Console.ReadLine());
            var br1 = 0;
            var br2 = 0;
            var br3 = 0;



            for (var i = 0; i < n; i++)
            {
                var num = int.Parse(Console.ReadLine());

                if (num % 2 == 0)
                {
                    br1++;
                }
                if (num % 3 == 0)
                {
                    br2++;
                }
                if (num % 4 == 0)
                {
                    br3++;
                }
            }

            var p1 = br1 / n * 100;
            var p2 = br2 / n * 100;
            var p3 = br3 / n * 100;
            Console.WriteLine("{0:f2}%", p1);
            Console.WriteLine("{0:f2}%", p2);
            Console.WriteLine("{0:f2}%", p3);
        }
    }
}
