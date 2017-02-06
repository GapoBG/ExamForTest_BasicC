using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxCombination
{
    class MaxComb
    {
        static void Main(string[] args)
        {
            var start = int.Parse(Console.ReadLine());
            var end = int.Parse(Console.ReadLine());
            var maxComb = int.Parse(Console.ReadLine());
            var br=0;

            for (int i = start; i <= end; i++)
            {
                for (int j = start; j <= end; j++)
                {
                    Console.WriteLine("<{0}-{1}>", i, j);
                    br++;
                    if (br == maxComb)
                    {
                        return;
                    }
                }
            }
        }
    }
}
