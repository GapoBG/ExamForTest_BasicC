using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Butterfly
{
    class butterfly
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            if (n == 3)
            {
                Console.WriteLine(new string('*', n - 2) + "\\" + " " + "/" + new string('*', n - 2));
                Console.WriteLine(new string(' ', n - 1) + "@" + new string(' ', n - 1));
                Console.WriteLine(new string('*', n - 2) + "/" + " " + "\\" + new string('*', n - 2));
            }
            else if (n > 3 && n <= 1000)
            {
                if (n % 2 != 0)
                {
                    Console.WriteLine(new string('*', n - 2) + "\\" + " " + "/" + new string('*', n - 2));
                    for (int i = 5; i <= n; i+=2)
                    {
                        Console.WriteLine(new string('-', n - 2) + "\\" + " " + "/" + new string('-', n - 2));
                        Console.WriteLine(new string('*', n - 2) + "\\" + " " + "/" + new string('*', n - 2));
                    }

                    Console.WriteLine(new string(' ', n - 1) + "@");

                    for (int i = 5; i <= n; i+=2)
                    {
                        Console.WriteLine(new string('*', n - 2) + "/" + " " + "\\" + new string('*', n - 2));
                        Console.WriteLine(new string('-', n - 2) + "/" + " " + "\\" + new string('-', n - 2));
                    }
                    Console.WriteLine(new string('*', n - 2) + "/" + " " + "\\" + new string('*', n - 2));

                }

            }

            else
            {
                Console.WriteLine("Sorry, Nxt Time. Enter Number [3...1000]");
            }
        }
    }
}
