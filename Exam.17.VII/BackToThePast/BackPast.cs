using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackToThePast
{
    class BackPast
    {
        static void Main(string[] args)
        {
            var money = double.Parse(Console.ReadLine());
            var years = int.Parse(Console.ReadLine());

            for (var i = 1800; i <= years; i++)
            {
                if (i % 2 == 0)
                {
                    money = money - 12000;
                }
                else
                {
                    money = money - (12000 + (18 + (i-1800)) * 50);
                }
            }
            if (money >= 0)
            {
                Console.WriteLine("Yes! He will live a carefree life and will have {0:f2} dollars left.", money);
            }
            else
            {
                Console.WriteLine("He will need {0:f2} dollars to survive.", Math.Abs(money));
            }



        }
    }
}
