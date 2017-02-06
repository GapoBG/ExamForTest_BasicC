using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOnSegment
{
    class PointSegment
    {
        static void Main(string[] args)
        {
            var first = int.Parse(Console.ReadLine());
            var second = int.Parse(Console.ReadLine());
            var point = int.Parse(Console.ReadLine());
            var deltaFirst = Math.Abs(first - point);
            var deltaSecond = Math.Abs(point - second);

            if (first < second)
            {
                if (point >= first && point <= second)
                {
                    Console.WriteLine("in");
                    if (deltaFirst > deltaSecond)
                    {
                        Console.WriteLine(deltaSecond);
                    }
                    else
                    {
                        Console.WriteLine(deltaFirst);
                    }
                }
                else
                {
                    Console.WriteLine("out");
                    if (deltaFirst > deltaSecond)
                    {
                        Console.WriteLine(deltaSecond);
                    }
                    else
                    {
                        Console.WriteLine(deltaFirst);
                    }

                }
            }
            else
            {
                if (point <= first && point >= second)
                {
                    Console.WriteLine("in");
                    if (deltaFirst > deltaSecond)
                    {
                        Console.WriteLine(deltaSecond);
                    }
                    else
                    {
                        Console.WriteLine(deltaFirst);
                    }
                }
                else
                {
                    Console.WriteLine("out");
                    if (deltaFirst > deltaSecond)
                    {
                        Console.WriteLine(deltaSecond);
                    }
                    else
                    {
                        Console.WriteLine(deltaFirst);
                    }

                }
            }
        }
    }
}
