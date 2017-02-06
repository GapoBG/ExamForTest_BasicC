using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operations
{
    class operations
    {
        static void Main(string[] args)
        {
            var N1 = double.Parse(Console.ReadLine());
            var N2 = double.Parse(Console.ReadLine());
            var made = Console.ReadLine();
            double resultat = 0.00;

            if (made == "+")
            {
                resultat = N1 + N2;

                if (resultat % 2 == 0)
                {
                    Console.WriteLine("{0} + {1} = {2} - even", N1, N2, resultat);
                }
                else
                {
                    Console.WriteLine("{0} + {1} = {2} - odd", N1, N2, resultat);
                }
            }
            else if (made == "-")
            {
                resultat = N1 - N2;

                if (resultat % 2 == 0)
                {
                    Console.WriteLine("{0} - {1} = {2} - even", N1, N2, resultat);
                }
                else
                {
                    Console.WriteLine("{0} - {1} = {2} - odd", N1, N2, resultat);
                }
            }
            else if (made == "*")
            {
                resultat = N1 * N2;

                if (resultat % 2 == 0)
                {
                    Console.WriteLine("{0} * {1} = {2} - even", N1, N2, resultat);
                }
                else
                {
                    Console.WriteLine("{0} * {1} = {2} - odd", N1, N2, resultat);
                }
            }

            else if (made == "/")
            {
                if (N2 != 0)
                {
                    resultat = N1 / N2;
                    Console.WriteLine("{0} / {1} = {2:f2}",N1, N2, resultat);
                }
                else
                {
                    Console.WriteLine("Cannot divide {0} by zero", N1);
                }
            }


            else if (made == "%")
            {
                if (N2 != 0)
                {
                    resultat = N1 % N2;
                    Console.WriteLine("{0} % {1} = {2}", N1, N2, resultat);
                }
                else
                {
                    Console.WriteLine("Cannot divide {0} by zero", N1);
                }
            }
        }
    }
}
