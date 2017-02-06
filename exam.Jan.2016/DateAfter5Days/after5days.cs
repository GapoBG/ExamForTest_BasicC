using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateAfter5Days
{
    class after5days
    {
        static void Main(string[] args)
        {
            var dd = int.Parse(Console.ReadLine());
            var mm = int.Parse(Console.ReadLine());
            var newDD = 0;

            newDD = dd + 5;

            if ((mm == 04) || (mm == 06) || (mm == 09) || (mm == 11))
            {
                if (newDD > 30) 
                {
                    dd = newDD - 30;
                    mm++;
                }
                else
                {
                    dd = newDD;
                }
            }
            else if ((mm == 01) || (mm == 03) || (mm == 05) || (mm == 07) || (mm == 08) || (mm ==10) || (mm == 12))
            {
                if (newDD > 31)
                {
                    dd = newDD - 31;
                    mm++;
                    if (mm == 13)
                    {
                        mm = 1;
                    }

                }
                else
                {
                    dd = newDD;
                }
            }
            else if (mm == 02)
            {
                if (newDD > 28)
                {
                    dd = newDD - 28;
                    mm++;
                }
                else
                {
                    dd = newDD;
                }
            }


            Console.WriteLine("{0}.{1:00}", dd, mm);
        }
    }
}
