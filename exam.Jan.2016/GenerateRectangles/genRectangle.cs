using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerateRectangles
{
    class genRectangle
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var minP = int.Parse(Console.ReadLine());
            bool printNo = true;

            for (int left = -n; left <= n; left++)
            {
                for (int top = -n; top <= n; top++)
                { 
                    for (int botton = top +1; botton <=n; botton++)
                    {
                        for (int right = left + 1; right <= n; right++)
                        {
                            int width = right - left;
                            int height = botton - top;
                            int area = width * height;
                            if (area >= minP)
                            {
                                Console.WriteLine("({0}, {1}) ({2}, {3}) -> {4}", left,top,right,botton,area);
                                printNo = false;
                            }
                        }
                    }
                }
            }
            if (printNo)
            {
                Console.WriteLine("No");
            }
        }
    }
}
