using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepairTiled
{
    class RepairTiled
    {
        static void Main(string[] args)
        {
            var N = int.Parse(Console.ReadLine());
            var W = double.Parse(Console.ReadLine());
            var L = double.Parse(Console.ReadLine());
            var M = int.Parse(Console.ReadLine());
            var O = int.Parse(Console.ReadLine());

            var area = N * N;
            var banch = M * O;
            var areaForTiled = area - banch;
            var areaTiled = L * W;
            var needTiled = areaForTiled / areaTiled;
            var needTime = needTiled * 0.2;

            Console.WriteLine(needTiled);
            Console.WriteLine(needTime);

        }
    }
}
