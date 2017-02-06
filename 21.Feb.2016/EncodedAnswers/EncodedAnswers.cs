using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncodedAnswers
{
    class EncodedAnswers
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var brA = 0;
            var brB = 0;
            var brC = 0;
            var brD = 0;
            string result = null;

            for (int i = 1; i <= n; i++)
            {
                var num = uint.Parse(Console.ReadLine());
                string answer;

                if (num % 4 == 0)
                {
                    answer = "a";
                    brA++;
                }
                else if (num % 4 == 1)
                {
                    answer = "b";
                    brB++;
                }
                else if (num % 4 == 2)
                {
                    answer = "c";
                    brC++;
                }
                else
                {
                    answer = "d";
                    brD++;
                }
                result += answer + ' ';
            }
            Console.WriteLine(result);
            Console.WriteLine("Answer A: {0}\nAnswer B: {1}\nAnswer C: {2}\nAnswer D: {3}", brA, brB, brC, brD);
        }
    }
}
