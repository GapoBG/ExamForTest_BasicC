using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fox
{
    class Fox
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var star = 1;
            var middleStar = n;
            var dash = (2 * n - 1);


            if (n!=2 && n>=7 && n<=57)
            {
                for (int i = 1; i <= n; i++)
                {
                    Console.WriteLine(new string('*',star) + "\\" + new string('-',dash) + "/" + new string('*',star));
                    star++;
                    dash-=2;
                }

                    star = (n - 1) / 2;
                    for (int i = 1; i <= n/3; i++)
                    {
                        Console.WriteLine("|" + new string('*', star) + "\\" + new string('*', middleStar) + "/" + new string('*', star) + "|");
                        star++;
                        middleStar -= 2;
                    }

                dash = 1;
                star = (2 * n - 1);
                for (int i = 1; i <= n; i++)
                {
                    Console.WriteLine(new string('-', dash) + "\\" + new string('*', star) + "/" + new string('-', dash));
                    star-=2;
                    dash++;
                }
            }
        }
    }
}
