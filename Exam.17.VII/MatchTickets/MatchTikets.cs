using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchTickets
{
    class MatchTikets
    {
        static void Main(string[] args)
        {
            var budget = double.Parse(Console.ReadLine());
            var category = Console.ReadLine();
            var personGroup = int.Parse(Console.ReadLine());
            var transport = 0.00;
            var moneyAfterTrans = 0.00;
            var delta = 0.00;
            
            

            switch (category)
            { 
                case "VIP":
                    {
                        var tiketsVip = 499.99;

                        if (personGroup >= 1 && personGroup <= 4)
                        {
                        transport = budget*0.75;
                        }
                        else if (personGroup >= 5 && personGroup <= 9)
                        {
                        transport = budget*0.60;
                        }               
                        else if (personGroup >= 10 && personGroup <= 24)
                        {
                        transport = budget*0.50;
                        }
                        else if (personGroup >= 25 && personGroup <= 49)
                        {
                        transport = budget*0.40;
                        }
                        else if (personGroup >= 50)
                        {
                        transport = budget*0.25;
                        }

                        var leftMoney = budget - transport;
                        var moneyTickets = tiketsVip * personGroup;

                        if (leftMoney > moneyTickets)
                        {
                            delta = leftMoney - moneyTickets;
                            Console.WriteLine("Yes! You have {0:f2} leva left.", delta);
                        }
                        else
                        {
                            delta = moneyTickets - leftMoney;
                            Console.WriteLine("Not enough money! You need {0:f2} leva.", delta);
                        }


                break;
                }
                case "Normal":
                { 
                        var tiketsNormal = 249.99;

                        if (personGroup >= 1 && personGroup <= 4)
                        {
                        transport = budget*0.75;
                        }
                        else if (personGroup >= 5 && personGroup <= 9)
                        {
                        transport = budget*0.60;
                        }               
                        else if (personGroup >= 10 && personGroup <= 24)
                        {
                        transport = budget*0.50;
                        }
                        else if (personGroup >= 25 && personGroup <= 49)
                        {
                        transport = budget*0.40;
                        }
                        else if (personGroup >= 50)
                        {
                        transport = budget*0.25;
                        }

                        var leftMoney = budget - transport;
                        var moneyTickets = tiketsNormal * personGroup;

                        if (leftMoney >= moneyTickets)
                        {
                            delta = leftMoney - moneyTickets;
                            Console.WriteLine("Yes! You have {0:f2} leva left.", delta);
                        }
                        else
                        {
                            delta = moneyTickets - leftMoney;
                            Console.WriteLine("Not enough money! You need {0:f2} leva.", delta);
                        }
                    break;
                }

                default:
                    {
                        Console.WriteLine("unknow");
                        break;
                    }
            }
        

        }
    }
}
