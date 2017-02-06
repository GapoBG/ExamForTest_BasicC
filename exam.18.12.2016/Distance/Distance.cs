using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distance
{
    class Distance
    {
        static void Main(string[] args)
        {
            var Vo = int.Parse(Console.ReadLine());
            var t1mm = double.Parse(Console.ReadLine());
            var t2mm = double.Parse(Console.ReadLine());
            var t3mm = double.Parse(Console.ReadLine());

            var t1HH = t1mm/60;
            var t2HH = t2mm/60;
            var t3HH = t3mm/60;
            var trace = Vo * t1HH;
            var VoUp = (Vo + Vo * 0.1) * t2HH;
            var VoDown = ((Vo + Vo * 0.1) - (Vo + Vo * 0.1) * 0.05) * t3HH;

            var result = trace + VoUp + VoDown;
            Console.WriteLine("{0:f2}",result);
        }
    }
}
