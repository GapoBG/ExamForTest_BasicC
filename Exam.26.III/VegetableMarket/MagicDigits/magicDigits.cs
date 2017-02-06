using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicDigits
{
    class magicDigits
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());


            for (int i = 100000; i <= 999999; i++)
            {
                var result = 1;
                int num = i;
                do
                {
                    result = result * (num % 10);
                    num = num / 10;
                }
                while (num > 0);

                if (result == n)
                {
                    Console.Write("{0} ", i);
                }
            }
        }
    }
}
