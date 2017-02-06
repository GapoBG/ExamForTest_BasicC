using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleArea
{
    class TriangleArea
    {
        static void Main(string[] args)
        {
            var x1 = double.Parse(Console.ReadLine());
            var y1 = double.Parse(Console.ReadLine());
            var x2 = double.Parse(Console.ReadLine());
            var y2 = double.Parse(Console.ReadLine());
            var x3 = double.Parse(Console.ReadLine());
            var y3 = double.Parse(Console.ReadLine());

            var a = 0.00;
            var h = 0.00;
            var area = 0.00;

            if (y2 == y3)
            {
                a = Math.Abs(x2 - x3);
                Console.WriteLine(a);
                h = Math.Abs(y2 - y1);
                Console.WriteLine(h);
                area = (a * h) / 2;
                Console.WriteLine(area);
            }
            else 
            {
                Console.WriteLine("error");
            }
        }
    }
}
