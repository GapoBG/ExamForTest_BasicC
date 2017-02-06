using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digits
{
    class Digits
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            var firstNum = num / 100;
            var secondNum = (num / 10) % 10;
            var thirdNum = (num % 10);

            var n = firstNum + secondNum;
            var m = firstNum + thirdNum;

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= m; j++)
                {
                    if (num % 5 == 0)
                    {
                        num = num - firstNum;
                    }
                    else if (num % 3 == 0)
                    {
                        num = num - secondNum;
                    }
                    else if ((num % 5 != 0) && (num % 3 != 0))
                    {
                        num = num + thirdNum;
                    }
                    Console.Write(num);

                    if (j < m)
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }

        }
    }
}
