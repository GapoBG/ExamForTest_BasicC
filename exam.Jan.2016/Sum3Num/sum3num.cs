using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum3Num
{
    class sum3num
    {
        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            var c = int.Parse(Console.ReadLine());

            if (a + b == c)
            {
                if (b > a)
                {
                    Console.WriteLine("{0} {1} {2}", a, b, c);
                }
                else if (a > b)
                {
                    Console.WriteLine("{0} {1} {2}", b, a, c);
                }
                else if (a == b)
                {
                    Console.WriteLine("{0} {1} {2}", b, a, c);
                }
            }
            else if (a + c == b)
            {
                if (a > c)
                {
                    Console.WriteLine("{0} {1} {2}", c, a, b);
                }
                else if (c > a)
                {
                    Console.WriteLine("{0} {1} {2}", a, c, b);
                }
                else if (a == c)
                {
                    Console.WriteLine("{0} {1} {2}", a, c, b);
                }
            }
            else if (b + c == a)
            {
                if (b > c)
                {
                    Console.WriteLine("{0} {1} {2}", c, b, a);
                }
                else if (c > b)
                {
                    Console.WriteLine("{0} {1} {2}", b, c, a);
                }
                else if (b == c) 
                {
                    Console.WriteLine("{0} {1} {2}", b, c, a);
                }

            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
