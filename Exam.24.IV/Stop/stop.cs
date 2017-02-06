using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stop
{
    class stop
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var row = n;
            var dot = 1;
            var dash = (2 * n) - 1;
            var dash2 = (4 * n) - 3;

            Console.WriteLine(new string('.',(n+1)) + new string('_',(2*n + 1)) + new string('.',(n+1)));

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(new string('.', row) + "//" + new string('_', dash) + @"\\" + new string('.', row));
                row--;
                dash += 2;
            }
            Console.WriteLine("//" + new string('_',((2*n)-3)) + "STOP!" + new string('_',((2*n)-3)) + @"\\");
            Console.WriteLine(@"\\" + new string('_',((4*n)-1)) + "//");

            for (int i = 0; i < n - 1; i++)
            {
                Console.WriteLine(new string('.', dot) + @"\\" + new string('_',dash2) + "//" + new string('.', dot));
                dot++;
                dash2 -= 2;
            }

         }
    }
}
