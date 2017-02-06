using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money
{
    class money
    {
        static void Main(string[] args)
        {
            var hisBitCoins = int.Parse(Console.ReadLine());
            var hisChineUana = double.Parse(Console.ReadLine());
            var commission = double.Parse(Console.ReadLine()) / 100.00;              
            
            var bitCoinsToBGN = hisBitCoins*1168.0;
            var UanaToUSD = hisChineUana*0.15;
            var USDtoBGN = UanaToUSD*1.76;
            var moneyEUR = (bitCoinsToBGN + USDtoBGN)/1.95;
            var moneyCommission = moneyEUR*commission;
           
            var result = moneyEUR - moneyCommission;
            Console.WriteLine(result);
        }
    }
}
