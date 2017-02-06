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
                        for (char d = (char)097; d < (char)097 + l; d++)
                        {
                            for (char e = (char)097; e < (char)097 + l; e++)
                            {
                                for (int m = 1; m <= n; m++)
                                {
                                    if (m > i && m > j)
                                    {
                                        Console.Write("{0}{1}{2}{3}{4} ",i,j,d,e,m);
                                    }
                                }
                            }
                        }
                    }
                }


        }
    }
}
