using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StopNumber
{
    class StopNum
    {
        static void Main(string[] args)
        {
            var end = int.Parse(Console.ReadLine());
            var start = int.Parse(Console.ReadLine());
            var stop = int.Parse(Console.ReadLine());

            for (int i = start; i >= end; i--)
            { 
            if (i%3==0 && i%2==0)
                {
                    if (i == stop)
                    {
                        break;
                    }
                    Console.Write("{0} ", i);
                }            
            }
        }
    }
}
