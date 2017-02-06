using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoolPipes
{
    class PoolPipes
    {
        static void Main(string[] args)
        {
            var V = double.Parse(Console.ReadLine());
            var p1 = double.Parse(Console.ReadLine());
            var p2 = double.Parse(Console.ReadLine());
            var HH = double.Parse(Console.ReadLine());
            var resultP1 = p1 * HH;
            var resultP2 = p2 * HH;
            var allPipe = resultP1 + resultP2;
            var FullPool = (int)((allPipe / V) * 100);
            var percentP1 = (int)((resultP1 / allPipe) * 100);
            var percentP2 = (int)((resultP2 / allPipe) * 100);
            var overflows = (allPipe) - V;
            


            if (allPipe <= V)
            {
                Console.WriteLine("The pool is {0}% full. Pipe 1: {1}%. Pipe 2: {2}%.",
                    FullPool, percentP1, percentP2);
            }
            else 
            {
                Console.WriteLine("For {0} hours the pool overflows with {1} liters.", HH, overflows );
            }

        }
    }
}
