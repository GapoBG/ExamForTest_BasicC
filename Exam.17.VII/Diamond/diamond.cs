using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond
{
    class diamond
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var dotUP = n-1;
            var dotMiddleUP = (5 * n) - 2 * (n - 1) - 2;
            var dotDown = 1;
            var dotMiddleDown = (5*n)-4;

            Console.WriteLine(new string('.',n) + new string('*', 3*n) + new string('.',n));
             for (int i = 1; i < n; i++ )
            {
            Console.WriteLine(new string('.',dotUP) + "*" + new string('.',dotMiddleUP) + "*" + new string('.',dotUP));
            dotUP--;
            dotMiddleUP += 2;
            }
             Console.WriteLine(new string('*', 5*n));
            for (int i=1; i <= 2*n; i++)
            {
                Console.WriteLine(new string('.', dotDown) + "*" + new string('.', dotMiddleDown) + "*" + new string('.', dotDown));
                dotDown++;
                dotMiddleDown -= 2; 
            }
            Console.WriteLine(new string('.', dotDown) + "*" + new string('*', dotMiddleDown) + "*" + new string('.', dotDown));


        }
    }
}
