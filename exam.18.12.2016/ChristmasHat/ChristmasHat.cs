using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChristmasHat
{
    class ChristmasHat
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var dot = (2*n) -1;
            var dash = 0;

            Console.WriteLine(new string('.',dot) + "/|\\" + new string('.',dot));
            Console.WriteLine(new string('.', dot) + "\\|/" + new string('.', dot));

            for (int i = 1; i <= 2*n; i++)
            {
                Console.WriteLine(new string('.',dot) + "*" + new string('-',dash) + "*" + new string('-',dash) + "*" + new string('.',dot));
                dot--;
                dash++;
            }
            Console.WriteLine(new string('*', 4*n +1));
            Console.WriteLine("*" + string.Join("",Enumerable.Repeat(".*",2*n)));
            Console.WriteLine(new string('*', 4 * n + 1));
        }
    }
}
