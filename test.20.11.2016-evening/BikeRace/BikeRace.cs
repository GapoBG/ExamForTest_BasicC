using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeRace
{
    class BikeRace
    {
        static void Main(string[] args)
        {
            var brJuniors = int.Parse(Console.ReadLine());
            var brSenior = int.Parse(Console.ReadLine());
            var trace = Console.ReadLine().ToLower();
            var allMoney = 0.0;
            var tax = 0.0;
            var result = 0.0;

            if (trace == "trail")
            {
                allMoney = brJuniors * 5.5 + brSenior * 7;
                tax = allMoney * 0.05;
                result = allMoney - tax;
            }

            else if (trace == "cross-country")
            {
                if (brSenior + brJuniors >= 50)
                {
                    allMoney = brJuniors * 8 + brSenior * 9.50 - (brJuniors * 8 + brSenior * 9.50)*0.25;
                    tax = allMoney * 0.05;
                    result = allMoney - tax;
                }
                else
                {
                    allMoney = brJuniors * 8 + brSenior * 9.50;
                    tax = allMoney * 0.05;
                    result = allMoney - tax;
                }
            
            }

            else if (trace == "downhill")
            {
                allMoney = brJuniors * 12.25 + brSenior * 13.75;
                tax = allMoney * 0.05;
                result = allMoney - tax;
            }
            else if (trace == "road")
            {
                allMoney = brJuniors * 20 + brSenior * 21.50;
                tax = allMoney * 0.05;
                result = allMoney - tax;
            }

            Console.WriteLine("{0:f2}", result);
        }
    }
}
