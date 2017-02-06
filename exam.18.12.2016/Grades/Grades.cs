using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class Grades
    {
        static void Main(string[] args)
        {
            var n = double.Parse(Console.ReadLine());
            var br1 = 0;
            var br2 = 0;
            var br3 = 0;
            var br4 = 0;
            var sum = 0.0;



            for (int i = 1; i <= n; i++)
            {
                var grade = double.Parse(Console.ReadLine());

                if (grade < 3.00)
                {
                    br1++;
                }
                else if (grade >= 3.00 && grade <= 3.99)
                {
                    br2++;
                }
                else if (grade >= 4.00 && grade <= 4.99)
                {
                    br3++;
                }
                else if (grade >= 5.00 && grade <= 6.00)
                {
                    br4++;
                }
                sum = sum + grade;
            }
            var avarage = sum / n;
            var topStudent = (br4 / n) * 100;
            var between1 = (br3 / n) * 100;
            var between2 = (br2 / n) * 100;
            var fail = (br1 / n) * 100;

            Console.WriteLine("Top students: {0:f2}%",topStudent);
            Console.WriteLine("Between 4.00 and 4.99: {0:f2}%", between1);
            Console.WriteLine("Between 3.00 and 3.99: {0:f2}%", between2);
            Console.WriteLine("Fail: {0:f2}%", fail);
            Console.WriteLine("Average: {0:f2}", avarage);
        }
    }
}
