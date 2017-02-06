using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawFort
{
    class drawFort
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var k = 0;

            if (n % 2 != 0)
            {
                k = 1;
            }
            Console.WriteLine("/" + new string('^', n / 2) + "\\" + new string('_', 2 * n - n - 4 + k) + "/" +
                new string('^', n / 2) + "\\");

            for (int i = 0; i < n - 2; i++)
            {
                if (i != n - 3)
                {
                    Console.WriteLine("|" + new string(' ', 2*n-2) + "|");
                }

                else
                {
                Console.WriteLine("|" + new string (' ',n/2+1) + new string('_', 2*n-n-4+k)
                    + new string(' ', n/2 +1) + "|");
                }


            }
            Console.WriteLine("\\" + new string('_', n / 2) + "/" + new string(' ', 2 * n - n - 4 + k) + "\\" +
    new string('_', n / 2) + "/");
        }
    }
}
