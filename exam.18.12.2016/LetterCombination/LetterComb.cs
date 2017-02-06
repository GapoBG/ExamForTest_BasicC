using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetterCombination
{
    class LetterComb
    {
        static void Main(string[] args)
        {
            var start = char.Parse(Console.ReadLine());
            var stop = char.Parse(Console.ReadLine());
            var miss = char.Parse(Console.ReadLine());

            for (char i = start; i <= stop; i++)
            {
                if (i==miss)
                {
                continue;
                }
                for (char j = start; j <= stop; j++)
                {
                if (j==miss)
                {
                continue;
                }
                    for (char k = start; k <= stop; k++)
                    {
                if (i==miss)
                {
                continue;
                }

                        Console.WriteLine("{0}{1}{2}", i,j,k);
                    }
                }
            }

        }
    }
}
