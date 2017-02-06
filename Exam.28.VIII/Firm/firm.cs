using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firm
{
    class firm
    {
        static void Main(string[] args)
        {
            var needHours = int.Parse(Console.ReadLine());
            var haveDays = int.Parse(Console.ReadLine());
            var people = int.Parse(Console.ReadLine());

            var HoursStudy = haveDays - (haveDays*0.1);
            var HoursForWork = HoursStudy * 8;
            var PersonHoursUp = people * (2 * haveDays);
            var TotalHours = Math.Floor(HoursForWork + PersonHoursUp);

            if (TotalHours >= needHours)
            {
                var delta = TotalHours - needHours;
                Console.WriteLine("Yes!{0} hours left.", delta);
            }
            else
            {
                var delta = needHours - TotalHours;
                Console.WriteLine("Not enough time!{0} hours needed.", delta);
            }

        }
    }
}
