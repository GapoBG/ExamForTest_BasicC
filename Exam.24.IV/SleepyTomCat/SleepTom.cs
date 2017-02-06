using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SleepyTomCat
{
    class SleepTom
    {
        static void Main(string[] args)
        {

            var FreeDays = int.Parse(Console.ReadLine());
            var WorkDays = 365 - FreeDays;
            var realTimeMM = (WorkDays * 63) + (FreeDays * 127);
            var delta = Math.Abs(30000 - realTimeMM);
            var HH = delta / 60;
            var MM = delta % 60;

            if (realTimeMM < 30000)
            {
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine("{0} hours and {1} minutes less for play", HH, MM);
            }

            else
            {
                Console.WriteLine("Tom will run away");
                Console.WriteLine("{0} hours and {1} minutes more for play", HH, MM);
            }
        }
    }
}
