using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StupidPaswordGEN
{
    class StupidPassGen
    {
        static void Main(string[] args)
        {

            
            var n = int.Parse(Console.ReadLine());
            var l = int.Parse(Console.ReadLine());

                for (var i = 1; i < n; i++)

                {
                    for (var j = 1; j < n; j++)
                    {
                        Console.WriteLine("{0}{1}", i, j);
                    }
                }


        }
    }
}
