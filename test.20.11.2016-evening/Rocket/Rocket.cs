using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rocket
{
    class Rocket
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var dot = (3 * n - 2) / 2;
            var space = 0;



            if (n >= 4 && n <= 100)
            {
                for (int i = 1; i <= n; i++)
                {
                    Console.WriteLine(new string('.', dot) + "/" + new string(' ', space) + "\\" + new string('.', dot));
                    dot--;
                    space += 2;
                }
                Console.WriteLine(new string('.', n / 2) + new string('*', n * 2) + new string('.', n / 2));

                for (int i = 1; i <= 2*n; i++)
                {
                    Console.WriteLine(new string('.', n / 2) + "|" + new string('\\', (n * 2) - 2) + "|" + new string('.', n / 2));
                }

                dot = n / 2;
                var stars = (2 * n) - 2;
                for (int i = 1; i <= n / 2; i++)
                {
                    Console.WriteLine(new string('.', dot) + "/" + new string('*', stars) + "\\" + new string('.', dot));
                    dot--;
                    stars += 2;
                }
            
            }

        }
    }
}
