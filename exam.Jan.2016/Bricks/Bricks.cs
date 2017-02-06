using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bricks
{
    class Bricks
    {
        static void Main(string[] args)
        {
            var bricks = decimal.Parse(Console.ReadLine());
            var worker = decimal.Parse(Console.ReadLine());
            var m = decimal.Parse(Console.ReadLine());

            var firtstTime = m * worker;
            var result = bricks / firtstTime;
            Console.WriteLine(Math.Ceiling(result));

        }
    }
}
