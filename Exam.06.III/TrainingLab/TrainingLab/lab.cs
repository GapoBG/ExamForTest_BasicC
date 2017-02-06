using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingLab
{
    class lab
    {
        static void Main(string[] args)
        {
            var h = 0.0;
            var w = 0.0;
            double result = 0;

            while (h < 3 || h > 100)
            {
                Console.Write("Enter h = [3....100] ");
                h = double.Parse(Console.ReadLine());
            }
            while (w < 3 || w > 100)
            {
                Console.Write("Enter w = [3....100] ");
                w = double.Parse(Console.ReadLine());
            }
            h = h * 100;
            w = w * 100;
            double deskOnRow = (int)(w - 100)/70;
            double row = (int)(h / 120);

            result = (int)(deskOnRow * row) - 3;
            Console.WriteLine(result);
        }
    }
}
