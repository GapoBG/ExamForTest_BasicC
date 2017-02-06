using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleWithStars
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            Console.WriteLine(new string('%',n*2));

            if (n % 2 == 0)
            {
                for (int i = 1; i <= (n / 2) - 1; i++)
                {
                    Console.WriteLine("%" + new string(' ', (2 * n) - 2) + "%");
                }
                Console.WriteLine("%" + new string(' ', ((2 * n - 4) / 2)) + "**" + new string(' ', ((2 * n - 4) / 2)) + "%");
                for (int i = 1; i <= (n / 2) - 1; i++)
                {
                    Console.WriteLine("%" + new string(' ', (2 * n) - 2) + "%");
                }

            }
            else
            {
                for (int i = 1; i <= (n - 1)/2; i++)
                {
                    Console.WriteLine("%" + new string(' ', (2 * n) - 2) + "%");
                }
                Console.WriteLine("%" + new string(' ', ((2 * n - 4) / 2)) + "**" + new string(' ', ((2 * n - 4) / 2)) + "%");
                for (int i = 1; i <= (n - 1) / 2; i++)
                {
                    Console.WriteLine("%" + new string(' ', (2 * n) - 2) + "%");
                }
            }
            Console.WriteLine(new string('%', n * 2));
        }
    }
}
