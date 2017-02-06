using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerfectDiamant
{
    class PerfectDiamant
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var spaceUpleft = n - 2;
            var drowUp = 1;
            var spaceDownLeft = 1;
            var drowDown = n - 2;

            if (n > 0)
            {
                Console.WriteLine(new string(' ',n-1) + "*");

                for (int i = 1; i <= n - 1; i++)
                {
                    Console.WriteLine(new string(' ', spaceUpleft) + '*' + string.Join("", Enumerable.Repeat("-*", drowUp)));
                    spaceUpleft--;
                    drowUp++;

                }
                for (int i = n - 1; i >= 1; i--)
                {
                    Console.WriteLine(new string(' ', spaceDownLeft) + '*' + string.Join("", Enumerable.Repeat("-*", drowDown)));
                    spaceDownLeft++;
                    drowDown--;
                }
            }
        }
    }
}

