using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battle
{
    class Battle
    {
        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            var n = int.Parse(Console.ReadLine());
            var br=0;

            if (a >= 1 && a <= 100 || b >= 1 && b <= 100)
            {
                for (int j = 1; j <= a; j++)
                        {
                            for (int k = 1; k <= b; k++)
                            {
                                br++;
                                if (br > n)
                                {
                                    break;
                                }
                                Console.Write("({0} <-> {1}) ", j, k);
                            }
                        }               
            }
         }
     }
}

