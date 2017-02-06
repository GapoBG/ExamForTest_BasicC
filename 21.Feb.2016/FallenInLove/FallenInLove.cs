using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FallenInLove
{
    class FallenInLove
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var dotUp = 2 * n;
            var line = 0;
            var dotMiddle = 0;
            var dotDown = 1;
            var lineDown = n;

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("#" + new string('~', line) + "#" + new string('.', dotUp) + "#" + new string('.', dotMiddle) + "#" + new string('.', dotUp) + "#" + new string('~', line) + "#");
                line++;
                dotUp -= 2;
                dotMiddle += 2;
            }

            dotMiddle = 2 * n;
            for (int i = 0; i <= n; i++)
            {
                Console.WriteLine(new string('.', dotDown) + "#" + new string('~', lineDown) + "#" + new string('.', dotMiddle) + "#" + new string('~', lineDown) + "#" + new string('.', dotDown));
                dotDown += 2;
                lineDown--;
                dotMiddle -= 2;
            }

            dotDown -= 1;
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(new string('.', dotDown) + "##" + new string('.', dotDown));
            }

        }
    }
}
