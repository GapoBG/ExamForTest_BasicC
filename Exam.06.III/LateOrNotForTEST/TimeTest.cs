using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LateOrNotForTEST
{
    class TimeTest
    {
        static void Main(string[] args)
        {

            var TestHH = int.Parse(Console.ReadLine());
            var TestMM = int.Parse(Console.ReadLine());
            var ArriveHH = int.Parse(Console.ReadLine());
            var ArriveMM = int.Parse(Console.ReadLine());

            var TestTimeMM = TestHH * 60 + TestMM;
            var ArriveTimeMM = ArriveHH * 60 + ArriveMM;
            var deltaLateMM = ArriveTimeMM - TestTimeMM;
            var deltaEarlyMM = TestTimeMM - ArriveTimeMM;

            if (deltaLateMM > 1)
            {
                Console.WriteLine("Late");

                if (deltaLateMM < 60)
                {
                    var MM = deltaLateMM % 60;
                    Console.WriteLine("{0} minutes after the start", MM);
                }
                else if (deltaLateMM >= 60)
                {
                    var HH = deltaLateMM / 60;
                    var MM = deltaLateMM % 60;
                    Console.WriteLine("{0}:{1:00} hours after the start", HH, MM);
                }
                
            }


            if (deltaEarlyMM >= 0 && deltaEarlyMM <= 30)
            {
                Console.WriteLine("On time");
                if (deltaEarlyMM > 0 && deltaEarlyMM < 60)
                {
                    var MM = deltaEarlyMM % 60;
                    Console.WriteLine("{0} minutes before the start", MM);
                }
                else if (deltaEarlyMM >= 60)
                {
                    var HH = deltaEarlyMM / 60;
                    var MM = deltaEarlyMM % 60;
                    Console.WriteLine("{0:00}:{1:00} hours before the start", HH, MM);
                }
                else
                {
                    Console.WriteLine();
                }
            }
              
            else if (deltaEarlyMM > 30)
            {
                Console.WriteLine("Early");
                if (deltaEarlyMM < 60)
                {
                    var MM = deltaEarlyMM % 60;
                    Console.WriteLine("{0} minutes before the start", MM);
                }
                else if (deltaEarlyMM >= 60)
                {
                    var HH = deltaEarlyMM / 60;
                    var MM = deltaEarlyMM % 60;
                    Console.WriteLine("{0:}:{1:00} hours before the start", HH, MM);
                }
            }
        }
    }
}
