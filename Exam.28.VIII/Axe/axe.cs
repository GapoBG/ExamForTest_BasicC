using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axe
{
    class axe
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var midDash = 1;
            var lastDash = (2 * n) - 3;
            var firstDash = (3 * n);
            var midDashDown = n - 1;
            var lastDashDown = n - 1;

            Console.WriteLine(new string('-', firstDash) + "**" + new string('-', (5 * n) - firstDash - 2));

            for (int i = 1; i < n; i++)
            {
                Console.WriteLine(new string('-', firstDash) + "*" + new string('-', midDash) + "*" + new string('-', lastDash));
                midDash++;
                lastDash--;
            }
            if (n % 2 == 0)
            {
                for (int i = 0; i < n / 2; i++)
                {
                    Console.WriteLine(new string('*', firstDash) + "*" + new string('-', midDashDown) + "*" + new string('-', n - 1));
                }
                if (n == 2)
                {
                    Console.WriteLine(new string('-', 3 * n) + "***" + "-");
                }
                if (n > 2)
                {
                    for (int i = 0; i < (n / 2) - 1; i++)
                    {
                        Console.WriteLine(new string('-', firstDash) + "*" + new string('-', midDashDown) + "*" + new string('-', lastDashDown));
                        firstDash--;
                        midDashDown += 2;
                        lastDashDown--;
                    }
                    Console.WriteLine(new string('-', firstDash) + "*" + new string('*', midDashDown) + "*" + new string('-', lastDashDown));
                }
            }
            else
            {
                for (int i = 0; i < (n - 1) / 2; i++)
                {
                    Console.WriteLine(new string('*', firstDash) + "*" + new string('-', midDashDown) + "*" + new string('-',lastDashDown));

                }
                for (int i = 1; i < (n - 1) / 2; i++)
                {
                    Console.WriteLine(new string('-', firstDash) + "*" + new string('-', midDashDown) + "*" + new string('-',lastDashDown));
                    firstDash--;
                    lastDashDown--;
                    midDashDown += 2;
                }
                    Console.WriteLine(new string('-', firstDash) + "*" + new string('*', midDashDown) + "*" + new string('-', lastDashDown));
            }
        }
    }
}
